using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt022_Data
    {
        public List<XCONTA_Rpt022_Info> consultar_data(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, string IdCentroCosto, int IdNivel_a_mostrar
           , int IdPunto_cargo_grupo
           , int IdPunto_cargo
           , bool Mostrar_reg_Cero
           , bool MostrarCC, bool Considerar_Asiento_cierre_anual, string IdUsuario, ref String MensajeError)
        {
            try
            {
                List<XCONTA_Rpt022_Info> listadedatos = new List<XCONTA_Rpt022_Info>();

                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                using (EntitiesContabilidadRptGeneral BalanceGeneral = new EntitiesContabilidadRptGeneral())
                {


                    BalanceGeneral.SetCommandTimeOut(30000);//timeout 3 minutos

                    IList<spCON_Mayorizar_x_fecha_corte_Result> listBalance =
                        BalanceGeneral.spCON_Mayorizar_x_fecha_corte(IdEmpresa, FechaIni, FechaFin, IdCentroCosto, IdPunto_cargo_grupo, IdPunto_cargo, Mostrar_reg_Cero, MostrarCC, Considerar_Asiento_cierre_anual, IdUsuario).Where(v => v.gc_estado_financiero == "BG" && v.IdNivelCta <= IdNivel_a_mostrar).ToList();

                    ct_Plancta_nivel_Info info_nivel_2 = new ct_Plancta_nivel_Info();
                    ct_Plancta_nivel_Info info_nivel_3 = new ct_Plancta_nivel_Info();
                    ct_Plancta_nivel_Info info_nivel_4 = new ct_Plancta_nivel_Info();
                    ct_Plancta_nivel_Info info_nivel_5 = new ct_Plancta_nivel_Info();
                    ct_Plancta_nivel_Info info_nivel_6 = new ct_Plancta_nivel_Info();

                    ct_Plancta_nivel_Bus bus_nivel = new ct_Plancta_nivel_Bus();
                    info_nivel_2 = bus_nivel.Get_info_plancta_nivel(IdEmpresa, 2);
                    info_nivel_3 = bus_nivel.Get_info_plancta_nivel(IdEmpresa, 3);
                    info_nivel_4 = bus_nivel.Get_info_plancta_nivel(IdEmpresa, 4);
                    info_nivel_5 = bus_nivel.Get_info_plancta_nivel(IdEmpresa, 5);
                    info_nivel_6 = bus_nivel.Get_info_plancta_nivel(IdEmpresa, 6);
                    

                    List<ct_Plancta_Info> lst_nivel_2 = new List<ct_Plancta_Info>();
                    List<ct_Plancta_Info> lst_nivel_3 = new List<ct_Plancta_Info>();
                    List<ct_Plancta_Info> lst_nivel_4 = new List<ct_Plancta_Info>();
                    List<ct_Plancta_Info> lst_nivel_5 = new List<ct_Plancta_Info>();
                    List<ct_Plancta_Info> lst_nivel_6 = new List<ct_Plancta_Info>();
                    
                    ct_Plancta_Bus bus_plancta = new ct_Plancta_Bus();
                    lst_nivel_2 = bus_plancta.Get_List_Plancta(IdEmpresa, 2);
                    lst_nivel_3 = bus_plancta.Get_List_Plancta(IdEmpresa, 3);
                    lst_nivel_4 = bus_plancta.Get_List_Plancta(IdEmpresa, 4);
                    lst_nivel_5 = bus_plancta.Get_List_Plancta(IdEmpresa, 5);
                    lst_nivel_6 = bus_plancta.Get_List_Plancta(IdEmpresa, 6);

                    foreach (var item in listBalance)
                    {
                        if (item.IdNivelCta == IdNivel_a_mostrar)
                        {
                            XCONTA_Rpt022_Info itemInfo = new XCONTA_Rpt022_Info();
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
                            itemInfo.Credito_Mes_x_Movi = item.Credito_Mes_x_Movi;
                            itemInfo.Saldo_x_Movi = item.Saldo_x_Movi;
                            itemInfo.pc_EsMovimiento = item.pc_EsMovimiento;
                            itemInfo.nom_cuenta2 = item.IdCtaCble + " - " + item.nom_cuenta;
                            itemInfo.nom_cuenta = item.nom_cuenta;
                            itemInfo.IdPuntoCargo = item.IdPunto_cargo;
                            itemInfo.IdPuntoCargo_Grupo = item.IdPunto_cargo_grupo;
                            itemInfo.IdCentroCosto = item.IdCentroCosto;
                            itemInfo.nom_PuntoCargo = item.nom_punto_cargo;
                            itemInfo.nom_PuntoCargo_Grupo = item.nom_punto_cargo_grupo;
                            itemInfo.nom_CentroCosto = item.nom_centro_costo;
                            itemInfo.nom_empresa = item.nom_empresa;
                            
                            //Nivel 2
                            itemInfo.IdCtaCble_nivel2 = item.IdCtaCble.Length > info_nivel_2.nv_NumDigitos_total ? itemInfo.IdCtaCble.Substring(0, Convert.ToInt32(info_nivel_2.nv_NumDigitos_total)) : null;
                            if (itemInfo.IdCtaCble_nivel2 != null) itemInfo.pc_cuenta_nivel2 = lst_nivel_2.FirstOrDefault(q => q.IdCtaCble == itemInfo.IdCtaCble_nivel2).pc_Cuenta;
                            //Nivel 3
                            itemInfo.IdCtaCble_nivel3 = item.IdCtaCble.Length > info_nivel_3.nv_NumDigitos_total ? itemInfo.IdCtaCble.Substring(0, Convert.ToInt32(info_nivel_3.nv_NumDigitos_total)) : null;
                            if (itemInfo.IdCtaCble_nivel3 != null) itemInfo.pc_cuenta_nivel3 = lst_nivel_3.FirstOrDefault(q => q.IdCtaCble == itemInfo.IdCtaCble_nivel3).pc_Cuenta;
                            //Nivel 4
                            itemInfo.IdCtaCble_nivel4 = item.IdCtaCble.Length > info_nivel_4.nv_NumDigitos_total ? itemInfo.IdCtaCble.Substring(0, Convert.ToInt32(info_nivel_4.nv_NumDigitos_total)) : null;
                            if (itemInfo.IdCtaCble_nivel4 != null) itemInfo.pc_cuenta_nivel4 = lst_nivel_4.FirstOrDefault(q => q.IdCtaCble == itemInfo.IdCtaCble_nivel4).pc_Cuenta;
                            //Nivel 5
                            itemInfo.IdCtaCble_nivel5 = item.IdCtaCble.Length > info_nivel_5.nv_NumDigitos_total ? itemInfo.IdCtaCble.Substring(0, Convert.ToInt32(info_nivel_5.nv_NumDigitos_total)) : null;
                            if (itemInfo.IdCtaCble_nivel5 != null) itemInfo.pc_cuenta_nivel5 = lst_nivel_5.FirstOrDefault(q => q.IdCtaCble == itemInfo.IdCtaCble_nivel5).pc_Cuenta;
                            //Nivel 6
                            itemInfo.IdCtaCble_nivel6 = item.IdCtaCble.Length > info_nivel_6.nv_NumDigitos_total ? itemInfo.IdCtaCble.Substring(0, Convert.ToInt32(info_nivel_6.nv_NumDigitos_total)) : null;
                            if (itemInfo.IdCtaCble_nivel6 != null) itemInfo.pc_cuenta_nivel6 = lst_nivel_6.FirstOrDefault(q => q.IdCtaCble == itemInfo.IdCtaCble_nivel6).pc_Cuenta;

                            listadedatos.Add(itemInfo);
                        }
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
