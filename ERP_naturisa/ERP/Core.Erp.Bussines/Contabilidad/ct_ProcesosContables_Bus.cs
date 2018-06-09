using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Contabilidad
{

    public class ct_ProcesosContables_Bus
    {

        string mensaje = "";
        ct_ProcesosContables_Data Odata = new ct_ProcesosContables_Data();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog=new tb_sis_Log_Error_Vzen_Bus();
        public ct_Periodo_Info _oPeriodo { get; set; }

        public Boolean ExisteErrorEnProceso { get; set; }
        
        public string MensajeError { get; set; }

        public ct_ProcesosContables_Bus(ct_Periodo_Info oPerid)
        {
            try
            {
                _oPeriodo = oPerid;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_ProcesosContables_Bus) };
            }

        }
       

        public bool ProcesoCierreAnual(ct_Periodo_Info Info_Periodo,ref string MensajeError_)
        {

            try
            {
                string MensajeError = "";
                Boolean res = false;

                ExisteErrorEnProceso = false;

                if (Info_Periodo == null)
                {
                    MensajeError_ = "Periodo esta en NULL";
                    return false;
                }

                int idPeriodo = Info_Periodo.IdPeriodo;
                int idanioF = Info_Periodo.IdanioFiscal;
                int idEmpresa = Info_Periodo.IdEmpresa;
                DateTime FechaIni = Convert.ToDateTime(Info_Periodo.pe_FechaIni.ToShortDateString());
                DateTime FechaFin = Convert.ToDateTime(Info_Periodo.pe_FechaFin.ToShortDateString());


                #region Creando Diario por cierre Anual

                DateTime Fecha_Cbte_x_Cierre;
                Fecha_Cbte_x_Cierre = FechaFin;

                string sObservacion_Cierre_Anual = "Asiento de cierre Anual del " + FechaFin.Year;
                ct_Cbtecble_Info InfoCbteCble = new ct_Cbtecble_Info();
                ct_Cbtecble_Bus BusCbteCble = new ct_Cbtecble_Bus();

                List<ct_Cbtecble_det_Info> List_det_CbteCble = new List<ct_Cbtecble_det_Info>();
                int IdTipoCbte_Cierre = 0;
                decimal IdCbteCble = 0;
                ct_Parametro_Bus BusParam_conta = new ct_Parametro_Bus();
                ct_Parametro_Info InfoParam_conta = new ct_Parametro_Info();
                InfoParam_conta = BusParam_conta.Get_Info_Parametro(Info_Periodo.IdEmpresa);
                IdTipoCbte_Cierre = InfoParam_conta.IdTipoCbte_AsientoCierre_Anual;


                InfoCbteCble.IdEmpresa = Info_Periodo.IdEmpresa;
                InfoCbteCble.IdTipoCbte = IdTipoCbte_Cierre;
                InfoCbteCble.IdCbteCble = 0;
                InfoCbteCble.CodCbteCble = "";
                InfoCbteCble.IdPeriodo = (Fecha_Cbte_x_Cierre.Year * 100) + Fecha_Cbte_x_Cierre.Month;
                InfoCbteCble.cb_Fecha = Fecha_Cbte_x_Cierre;
                InfoCbteCble.cb_Valor = 0;
                InfoCbteCble.cb_Observacion = sObservacion_Cierre_Anual;
                InfoCbteCble.Secuencia = 0;
                InfoCbteCble.Estado = "A";
                InfoCbteCble.Anio = Fecha_Cbte_x_Cierre.Year;
                InfoCbteCble.Mes = Fecha_Cbte_x_Cierre.Month;
                InfoCbteCble.IdUsuario = "";
                InfoCbteCble.cb_FechaTransac = DateTime.Now;
                InfoCbteCble.Mayorizado = "N";
                InfoCbteCble.IdSucursal = 1;

                List<ct_Plancta_Info> lst_plancta = new List<ct_Plancta_Info>();
                ct_Plancta_Bus bus_plancta = new ct_Plancta_Bus();
                lst_plancta = bus_plancta.Get_List_Plancta_para_asiento_cierre(param.IdEmpresa, Info_Periodo.IdanioFiscal);
                int sec = 1;
                double total = 0;
                foreach (var item in lst_plancta)
                {
                    ct_Cbtecble_det_Info info_Det = new ct_Cbtecble_det_Info();
                    info_Det.IdEmpresa = item.IdEmpresa;
                    info_Det.IdTipoCbte = IdTipoCbte_Cierre;
                    info_Det.secuencia = sec;
                    if (item.IdCtaCble == "51415")
                    {
                        
                    }
                    info_Det.IdCtaCble = item.IdCtaCble;
                    info_Det.dc_Valor = Math.Round(item.Saldo,2,MidpointRounding.AwayFromZero)*-1;
                    info_Det.IdPunto_cargo = item.IdPunto_cargo;
                    info_Det.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                    info_Det.IdCentroCosto = item.IdCentroCosto;
                    info_Det.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    info_Det.dc_para_conciliar = false;

                    InfoCbteCble._cbteCble_det_lista_info.Add(info_Det);
                    if (info_Det.dc_Valor > 0) total += info_Det.dc_Valor;
                    sec++;
                }
                InfoCbteCble.cb_Valor = Math.Round(total,2,MidpointRounding.AwayFromZero);




                ct_anio_fiscal_x_cuenta_utilidad_Info InfoCtaUtilidad = new ct_anio_fiscal_x_cuenta_utilidad_Info();
                ct_anio_fiscal_x_cuenta_utilidad_Bus BusCtaUtilidad = new ct_anio_fiscal_x_cuenta_utilidad_Bus();

                if (InfoCtaUtilidad.IdCbteCble_cbte_cierre == null)//no existe diario de cierre primera vez
                {

                    if (BusCbteCble.GrabarDB(InfoCbteCble, ref IdCbteCble, ref MensajeError))
                    {
                        InfoCtaUtilidad.IdEmpresa = Info_Periodo.IdEmpresa;
                        InfoCtaUtilidad.IdanioFiscal = Info_Periodo.IdanioFiscal;
                        InfoCtaUtilidad.IdEmpresa_cbte_cierre = InfoCbteCble.IdEmpresa;
                        InfoCtaUtilidad.IdTipoCbte_cbte_cierre = InfoCbteCble.IdTipoCbte;
                        InfoCtaUtilidad.IdCbteCble_cbte_cierre = InfoCbteCble.IdCbteCble;

                        BusCtaUtilidad.ModificiarDB_CbteCierre(InfoCtaUtilidad, ref MensajeError);
                        res = true;
                    }
                    else
                    {
                        MensajeError_ = "Error al Grabar el Diario de cierre.." + MensajeError;
                        res = false;
                    }
                }
                else // ya existe el asiento de cierre
                {

                    InfoCbteCble.IdEmpresa = Convert.ToInt32(InfoCtaUtilidad.IdEmpresa_cbte_cierre);
                    InfoCbteCble.IdTipoCbte = Convert.ToInt32(InfoCtaUtilidad.IdTipoCbte_cbte_cierre);
                    InfoCbteCble.IdCbteCble = Convert.ToDecimal(InfoCtaUtilidad.IdCbteCble_cbte_cierre);

                    if (BusCbteCble.ModificarDB(InfoCbteCble, ref MensajeError))
                    {
                        InfoCtaUtilidad.IdEmpresa = Info_Periodo.IdEmpresa;
                        InfoCtaUtilidad.IdanioFiscal = Info_Periodo.IdanioFiscal;
                        InfoCtaUtilidad.IdEmpresa_cbte_cierre = InfoCbteCble.IdEmpresa;
                        InfoCtaUtilidad.IdTipoCbte_cbte_cierre = InfoCbteCble.IdTipoCbte;
                        InfoCtaUtilidad.IdCbteCble_cbte_cierre = InfoCbteCble.IdCbteCble;
                        BusCtaUtilidad.ModificiarDB_CbteCierre(InfoCtaUtilidad, ref MensajeError);
                        MensajeError_ = MensajeError;
                        res = true;
                    }
                    else
                    {
                        MensajeError_ = "Error al Modificar el Diario de cierre.." + MensajeError;
                        res = false;
                    }

                }

                #endregion

                return res;

            }
            catch (Exception ex)
            {
                ExisteErrorEnProceso = true;
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_ProcesosContables_Bus) };

            }

        }


        public List<ct_Balance_x_Estado_Resultado_x_Usuario_Info> Get_Estado_Resultado(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return Odata.Get_Estado_Resultado(IdEmpresa, FechaIni, FechaFin,param.IdUsuario );
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_ProcesosContables_Bus) };
                
            }

        }

        //public void ProcesoMayorizar(ct_Periodo_Info oPeridoi)
        //{

        //    try
        //    {
        //        ExisteErrorEnProceso = false;

        //        if (oPeridoi == null)
        //        { return; }



        //        int idPeriodo = oPeridoi.IdPeriodo;
        //        int idanioF = oPeridoi.IdanioFiscal;
        //        int idEmpresa = oPeridoi.IdEmpresa;
        //        DateTime FechaIni = Convert.ToDateTime(oPeridoi.pe_FechaIni.ToShortDateString());
        //        DateTime FechaFin = Convert.ToDateTime(oPeridoi.pe_FechaFin.ToShortDateString());



        //        int CNivelMax = 0;


        //        ct_Cbtecble_Bus cbB = new ct_Cbtecble_Bus();
        //        List<ct_Cbtecble_Info> lmcbi = new List<ct_Cbtecble_Info>();
        //        ct_saldoxCuentas_Movi_Bus salMoviD = new ct_saldoxCuentas_Movi_Bus();

        //        List<ct_Plancta_Info> listCtasPadres = new List<ct_Plancta_Info>();
        //        ct_Plancta_Bus plB = new ct_Plancta_Bus();
        //        string MensajeError = "";


        //        lmcbi = cbB.Get_list_Cbtecble_Pendientes_ParaMayorizacion(idEmpresa, FechaIni, FechaFin, ref MensajeError);


              

        //        //obtengo todo el plna de cta
        //        List<ct_Plancta_Info> listPlanCtas = new List<ct_Plancta_Info>();
        //        List<ct_Plancta_Info> listPlanCtas_a_mayorizar = new List<ct_Plancta_Info>();

        //        listPlanCtas = plB.Get_List_Plancta(idEmpresa, ref mensaje);

                



        //        var TdebitosxCta = from Cb in lmcbi
        //                           where Cb._cbteCble_det_info.dc_Valor > 0
        //                           orderby Cb._cbteCble_det_info.IdCtaCble
        //                           group Cb by new { Cb.IdEmpresa, Cb._cbteCble_det_info.IdCtaCble }
        //                               into grouping
        //                               select new { grouping.Key, totaldebidoxCta = grouping.Sum(p => p._cbteCble_det_info.dc_Valor) };


        //        var TcreditoxCta = from Cb in lmcbi
        //                           where Cb._cbteCble_det_info.dc_Valor < 0
        //                           orderby Cb._cbteCble_det_info.IdCtaCble
        //                           group Cb by new { Cb.IdEmpresa, Cb._cbteCble_det_info.IdCtaCble }
        //                               into grouping
        //                               select new { grouping.Key, totalcreditoxCta = grouping.Sum(p => p._cbteCble_det_info.dc_Valor) * -1 };

        //        int TNRegC=TcreditoxCta.ToList().Count();
        //        int TNRegD = TdebitosxCta.ToList().Count();


        //        var ListaCtasCbles_x_cbtes = from Lctas in lmcbi
        //                             orderby Lctas._cbteCble_det_info.IdCtaCble
        //                             group Lctas by new { Lctas.IdEmpresa, Lctas._cbteCble_det_info.IdCtaCble, Lctas._cbteCble_det_info._Plancta_Info.IdCtaCblePadre
        //                                 , Lctas._cbteCble_det_info._Plancta_Info.pc_Naturaleza }
        //                                 into grouping
        //                                 select new { grouping.Key };


                




        //        foreach (var item in ListaCtasCbles_x_cbtes)
        //        {

        //            ct_Plancta_Info planI= new ct_Plancta_Info();

        //            planI.IdEmpresa = item.Key.IdEmpresa;
        //            planI.IdCtaCble = item.Key.IdCtaCble;
        //            planI.IdCtaCblePadre = item.Key.IdCtaCblePadre;
        //            planI.pc_Naturaleza = item.Key.pc_Naturaleza;
                   
        //            listPlanCtas_a_mayorizar.Add(planI);

                    
        //        }
              



        //        double debitoMensualxCta = 0;
        //        double creditoMensualxCta = 0;


        //        ct_saldoxCuentas_Movi_Bus saldoxCB = new ct_saldoxCuentas_Movi_Bus();
        //        List<ct_saldoxCuentas_Movi_Info> ListSaldoxCta_moviDB = new List<ct_saldoxCuentas_Movi_Info>();
        //        List<ct_saldoxCuentas_Movi_Info> ListSaldoxCta_moviDB_Actualizado = new List<ct_saldoxCuentas_Movi_Info>();
        //        List<ct_saldoxCuentas_Movi_Info> ListSaldo_Movi = new List<ct_saldoxCuentas_Movi_Info>();

        //        /// importante 
        //        ListSaldoxCta_moviDB = saldoxCB.Get_List_saldoxCuentas_Movi_x_Periodo(idEmpresa, idanioF, idPeriodo);
        //        //optengo las cuentas q tiene saldo inicial para poder acumular recuersivamente

        //        var ListaCtasCbles_x_cbtes_con_movi = from Lctas in ListSaldoxCta_moviDB
        //                                              join plancta in listPlanCtas
        //                                              on new { Lctas.IdEmpresa, Lctas.IdCtaCble } equals new { plancta.IdEmpresa, plancta.IdCtaCble }
        //                                              select new { plancta.IdEmpresa, plancta.IdCtaCble, plancta.IdCtaCblePadre, plancta.pc_Naturaleza};


        //        foreach (var item in ListaCtasCbles_x_cbtes_con_movi)
        //        {

        //            ct_Plancta_Info planI = new ct_Plancta_Info();
        //            planI.IdEmpresa = item.IdEmpresa;
        //            planI.IdCtaCble = item.IdCtaCble;
        //            planI.IdCtaCblePadre = item.IdCtaCblePadre;
        //            planI.pc_Naturaleza = item.pc_Naturaleza;

        //            listPlanCtas_a_mayorizar.Add(planI);
        //        }



        //        foreach (var item in listPlanCtas_a_mayorizar)
        //        {

        //            debitoMensualxCta = 0;
        //            creditoMensualxCta = 0;




        //            var RestDebitoxCta = from C in TdebitosxCta
        //                                 where C.Key.IdEmpresa == idEmpresa
        //                                 && C.Key.IdCtaCble.Contains(item.IdCtaCble)
        //                                 select C;

        //            foreach (var itemDeb in RestDebitoxCta)
        //            {
        //                debitoMensualxCta = itemDeb.totaldebidoxCta;
        //            }


        //            var RestCreaditoxCta = from C in TcreditoxCta
        //                                   where C.Key.IdEmpresa == idEmpresa
        //                                   && C.Key.IdCtaCble.Contains(item.IdCtaCble)
        //                                   select C;

        //            foreach (var itemCred in RestCreaditoxCta)
        //            {
        //                creditoMensualxCta = itemCred.totalcreditoxCta;
        //            }

        //            //1 objeto x saldo
        //            ct_saldoxCuentas_Movi_Info SalMovi_O = new ct_saldoxCuentas_Movi_Info();
        //            SalMovi_O.IdEmpresa = item.IdEmpresa;
        //            SalMovi_O.IdCtaCble = item.IdCtaCble.Trim();
        //            SalMovi_O.IdCtaCblePadre = item.IdCtaCblePadre.Trim();
        //            SalMovi_O.sc_debito_mes = debitoMensualxCta;
        //            SalMovi_O.sc_credito_mes = creditoMensualxCta;
        //            SalMovi_O.IdAnioF = idanioF;
        //            SalMovi_O.IdPeriodo = idPeriodo;
        //            ListSaldo_Movi.Add(SalMovi_O);


        //            ct_saldoxCuentas_Movi_Info ItemsEncontrado = ListSaldoxCta_moviDB.Find(delegate(ct_saldoxCuentas_Movi_Info p) { return p.IdCtaCble == SalMovi_O.IdCtaCble; });

        //            if (ItemsEncontrado == null) // no existe en la base insertar 
        //            {
        //                SalMovi_O.sc_saldo_anterior = 0;
        //                //SalMovi_O.sc_debito_acum = SalMovi_O.sc_debito_mes;
        //                //SalMovi_O.sc_credito_acum = SalMovi_O.sc_credito_mes;

        //                if (item.pc_Naturaleza == "D")
        //                {
        //                    SalMovi_O.sc_saldo_acum = SalMovi_O.sc_debito_mes - SalMovi_O.sc_credito_mes;
        //                }
        //                else
        //                {
        //                    SalMovi_O.sc_saldo_acum = (SalMovi_O.sc_credito_mes - SalMovi_O.sc_debito_mes);
        //                }

        //                ListSaldoxCta_moviDB_Actualizado.Add(SalMovi_O);
        //            }
        //            else
        //            {

        //                ct_saldoxCuentas_Movi_Info SalxCtaParaActualizar = new ct_saldoxCuentas_Movi_Info();
        //                SalxCtaParaActualizar = ItemsEncontrado;
        //                SalxCtaParaActualizar.sc_debito_mes = SalxCtaParaActualizar.sc_debito_mes + SalMovi_O.sc_debito_mes;
        //                SalxCtaParaActualizar.sc_credito_mes = SalxCtaParaActualizar.sc_credito_mes + SalMovi_O.sc_credito_mes;
        //                //SalxCtaParaActualizar.sc_debito_acum = SalxCtaParaActualizar.sc_debito_acum + SalMovi_O.sc_debito_mes;
        //                //SalxCtaParaActualizar.sc_credito_acum = SalxCtaParaActualizar.sc_credito_acum + SalMovi_O.sc_credito_mes;
        //                if (item.pc_Naturaleza == "D")
        //                {
        //                    SalxCtaParaActualizar.sc_saldo_acum = SalxCtaParaActualizar.sc_saldo_acum + (SalMovi_O.sc_debito_mes - SalMovi_O.sc_credito_mes);
        //                }
        //                else
        //                {
        //                    SalxCtaParaActualizar.sc_saldo_acum = SalxCtaParaActualizar.sc_saldo_acum + (SalMovi_O.sc_credito_mes - SalMovi_O.sc_debito_mes);
        //                }

        //                ListSaldoxCta_moviDB_Actualizado.Add(SalxCtaParaActualizar);


        //            }


        //        }// fin foreach

        //        //OPTENIENDO EL PLAN DE CUENTAs padres

        //        // ListSaldoxCta_moviDB_Actualizado : hasta aqui esta lista tiene todas las cuentas de movi
        //        // ya sumado sus saldo por deb y credio y natiraleza



        //        listCtasPadres = plB.Get_List_Plan_ctaPadre(idEmpresa, ref mensaje);
        //        //--------------------------------

        //        List<ct_SaldoxCuentas_Info> LSaldoxCuentas_Info = new List<ct_SaldoxCuentas_Info>();

        //        foreach (var item in listCtasPadres)
        //        {
        //            ct_SaldoxCuentas_Info SaldoxCuentas_O = new ct_SaldoxCuentas_Info();
        //            SaldoxCuentas_O.IdEmpresa = item.IdEmpresa;
        //            SaldoxCuentas_O.IdAnioF = idanioF;
        //            SaldoxCuentas_O.IdCtaCble = item.IdCtaCble;
        //            SaldoxCuentas_O.IdPeriodo = idPeriodo;
        //            SaldoxCuentas_O.sc_credito_acum = 0;
        //            SaldoxCuentas_O.sc_credito_mes = 0;
        //            SaldoxCuentas_O.sc_debito_mes = 0;
        //            SaldoxCuentas_O.sc_saldo_acum = 0;
        //            SaldoxCuentas_O.sc_saldo_anterior = 0;
        //            SaldoxCuentas_O.sc_saldo_mes = 0;

        //            LSaldoxCuentas_Info.Add(SaldoxCuentas_O);
        //        }


        //        //







        //        var ListasSaldosxCtasMovi = from Lctas in ListSaldoxCta_moviDB_Actualizado
        //                                    join Pl in listPlanCtas on new { Lctas.IdEmpresa, Lctas.IdCtaCble } equals new { Pl.IdEmpresa, Pl.IdCtaCble }
        //                                 //   where Lctas.IdCtaCble == "11010302"
        //                                    orderby Pl.IdNivelCta, Lctas.IdCtaCble
        //                                    select new
        //                                    {
        //                                        Lctas.IdAnioF,
        //                                        Lctas.IdCtaCble,
        //                                        Lctas.IdEmpresa,
        //                                        Lctas.IdPeriodo
        //                                        ,
        //                                        Lctas.sc_credito_mes,
        //                                        Lctas.sc_debito_mes,
        //                                        Lctas.sc_saldo_acum
        //                                        ,
        //                                        Lctas.sc_saldo_anterior,
        //                                        Pl.IdCtaCblePadre,
        //                                        Pl.IdNivelCta,
        //                                        Pl._Plancta_nivel_Info.nv_NumDigitos
        //                                    };

        //        List<ct_saldoxCuentas_Movi_Info> SalxCtasAux = new List<ct_saldoxCuentas_Movi_Info>();
        //        List<ct_saldoxCuentas_Movi_Info> SalxCtasAux_Base = new List<ct_saldoxCuentas_Movi_Info>();



        //        foreach (var item in ListasSaldosxCtasMovi)
        //        {

        //            ct_saldoxCuentas_Movi_Info saldxctaO = new ct_saldoxCuentas_Movi_Info();
        //            saldxctaO.IdEmpresa = item.IdEmpresa;
        //            saldxctaO.IdAnioF = item.IdAnioF;
        //            saldxctaO.IdPeriodo = item.IdPeriodo;
        //            saldxctaO.IdCtaCble = item.IdCtaCble;
        //            //saldxctaO.sc_credito_acum = item.sc_credito_acum;
        //            saldxctaO.sc_credito_mes = item.sc_credito_mes;
        //            //saldxctaO.sc_debito_acum = item.sc_debito_acum;
        //            saldxctaO.sc_debito_mes = item.sc_debito_mes;
        //            saldxctaO.sc_saldo_acum = item.sc_saldo_acum;
        //            saldxctaO.sc_saldo_anterior = item.sc_saldo_anterior;
        //            saldxctaO.IdCtaCblePadre = item.IdCtaCblePadre;
        //            //saldxctaO.sc_saldo_mes=item.sal
        //            SalxCtasAux.Add(saldxctaO);
        //            SalxCtasAux_Base.Add(saldxctaO);
        //        }



        //        List<ct_SaldoxCuentas_Info> ListSaldoxCtaMayorizado = new List<ct_SaldoxCuentas_Info>();

        //        ct_ProcesosContables_Bus NivelB = new ct_ProcesosContables_Bus();
        //        List<ct_Plancta_nivel_Info> listNivelP = new List<ct_Plancta_nivel_Info>();
        //        //listNivelP = NivelB.Get_list_Plancta_nivel(idEmpresa);


        //        var MaxNivel = (from nivelP in listNivelP
        //                        where nivelP.IdEmpresa == idEmpresa
        //                        select nivelP.IdNivelCta).Max();

        //        int CUltimoNivel = MaxNivel;

        //        CNivelMax = MaxNivel;
        //        CNivelMax--;


        //        ct_saldoxCuentas_Movi_Bus slmoB = new ct_saldoxCuentas_Movi_Bus();
        //        ct_saldoxCuentas_Bus slmoCtasB = new ct_saldoxCuentas_Bus();
        //        ct_Cbtecble_Bus cbBu = new ct_Cbtecble_Bus();



        //        while (CNivelMax >= 1)
        //        {



        //            // SalxCtasAux_Base nunca cambia para poder sacar datos q no sean del ultimo nivel 
        //            var ListSaldo_ctas_AgrupadoxNivel = from Lctas in SalxCtasAux_Base
        //                                     join Plan in listPlanCtas
        //                                     on new { Lctas.IdEmpresa, Lctas.IdCtaCble } equals new { Plan.IdEmpresa, Plan.IdCtaCble }
        //                                                where Plan.IdNivelCta == CNivelMax
        //                                     group Lctas by new { Lctas.IdEmpresa, Plan.IdCtaCblePadre, Plan.IdNivelCta }
        //                                         into grouping
        //                                         select new
        //                                         {
        //                                             grouping.Key
        //                                             ,
        //                                             sc_credito_mes = grouping.Sum(p => p.sc_credito_mes)
        //                                             ,
        //                                             sc_debito_mes = grouping.Sum(p => p.sc_debito_mes)
        //                                             ,
        //                                             sc_saldo_acum = grouping.Sum(p => p.sc_saldo_acum)
        //                                             ,
        //                                             sc_saldo_anterior = grouping.Sum(p => p.sc_saldo_anterior)
        //                                         };


        //            // agrupando por cuenta padre el listado q ya se acumulo por cuenta deb y cred
        //            //SalxCtasAux : variable auxiliar q contiene los saldos por cuenta de movimiento
        //            //listPlanCtas: contiene todo el plan de cuenta
        //            //agrupando el listado de cuentas de movi  por cuenta padre con su nivel plan de cuenta
        //            //encuentro los registros agrupados nivel por nivel no pierdo los datos de:SalxCtasAux
        //            var ListAgrupadoxNivel = from Lctas in SalxCtasAux
        //                                     join Plan in listPlanCtas
        //                                     on new { Lctas.IdEmpresa, Lctas.IdCtaCble } equals new { Plan.IdEmpresa, Plan.IdCtaCble }
        //                                     where Plan.IdNivelCta == CNivelMax
        //                                     group Lctas by new { Lctas.IdEmpresa, Plan.IdCtaCblePadre, Plan.IdNivelCta }
        //                                         into grouping
        //                                         select new
        //                                         {
        //                                             grouping.Key
        //                                             ,
                                                     
        //                                             sc_credito_mes = grouping.Sum(p => p.sc_credito_mes)
        //                                             ,
                                                     
        //                                             sc_debito_mes = grouping.Sum(p => p.sc_debito_mes)
        //                                             ,
        //                                             sc_saldo_acum = grouping.Sum(p => p.sc_saldo_acum)
        //                                             ,
        //                                             sc_saldo_anterior = grouping.Sum(p => p.sc_saldo_anterior)
        //                                         };



                    
        //            //recorriendo la agrupacion por nivel de cuenta padre ya esta sumada los saldos 

        //            foreach (var item in ListAgrupadoxNivel)
        //            {
        //                ct_SaldoxCuentas_Info saldxcta_padre = new ct_SaldoxCuentas_Info();
        //                ct_saldoxCuentas_Movi_Info saldxcta_Movi = new ct_saldoxCuentas_Movi_Info();

        //                if (item.Key.IdCtaCblePadre != "")
        //                {

        //                    saldxcta_padre.IdEmpresa = idEmpresa;
        //                    saldxcta_padre.IdAnioF = idanioF;
        //                    saldxcta_padre.IdPeriodo = idPeriodo;
        //                    saldxcta_padre.IdCtaCble = item.Key.IdCtaCblePadre;
        //                    saldxcta_padre.IdNivel = item.Key.IdNivelCta - 1;
        //                    saldxcta_padre.sc_credito_mes = item.sc_credito_mes;

        //                    saldxcta_padre.sc_debito_mes = item.sc_debito_mes;
        //                    saldxcta_padre.sc_saldo_acum = item.sc_saldo_acum;
        //                    saldxcta_padre.sc_saldo_anterior = item.sc_saldo_anterior;

        //                    saldxcta_Movi.IdEmpresa = item.Key.IdEmpresa;
        //                    saldxcta_Movi.IdAnioF = idanioF;
        //                    saldxcta_Movi.IdCtaCble = item.Key.IdCtaCblePadre;
        //                    saldxcta_Movi.IdPeriodo = idPeriodo;
        //                    saldxcta_Movi.sc_credito_mes = item.sc_credito_mes;
        //                    saldxcta_Movi.sc_debito_mes = item.sc_debito_mes;
        //                    saldxcta_Movi.sc_saldo_acum = item.sc_saldo_acum;
        //                    saldxcta_Movi.sc_saldo_anterior = item.sc_saldo_anterior;


        //                    ListSaldoxCtaMayorizado.Add(saldxcta_padre);
        //                    SalxCtasAux.Add(saldxcta_Movi);
        //                }




        //                SalxCtasAux = new List<ct_saldoxCuentas_Movi_Info>();

        //            }




        //            CNivelMax--;

        //        }



        //        // despues de mayorizar inserto y borro la base para almacenar los datos 
        //        //
        //        Boolean EstadoBorrarYUpdateDB = false;

        //        // borrando la base saldo x cta movi
        //        EstadoBorrarYUpdateDB = slmoB.EliminarDB_SaldoxCuentas_Movi(ListSaldoxCta_moviDB_Actualizado);

        //        if (EstadoBorrarYUpdateDB == true)
        //        {
        //            EstadoBorrarYUpdateDB = slmoCtasB.EliminarDB(ListSaldoxCtaMayorizado);


        //            if (EstadoBorrarYUpdateDB == true)
        //            {
        //                EstadoBorrarYUpdateDB = slmoB.GrabarDB(ListSaldoxCta_moviDB_Actualizado);

        //                if (EstadoBorrarYUpdateDB == true)
        //                {
        //                    EstadoBorrarYUpdateDB = slmoCtasB.GrabarDB(ListSaldoxCtaMayorizado,ref MensajeError);
        //                    if (EstadoBorrarYUpdateDB == true)
        //                    {
        //                        cbBu.ModificarDB_CbteMayorizado(idEmpresa, FechaIni, FechaFin, 'S', ref MensajeError);
        //                    }
        //                    else
        //                    {
        //                        ExisteErrorEnProceso = true;
        //                        MensajeError = "Error en el proceso de GrabarDBLista_SaldoxCuentas";
        //                    }
        //                }
        //                else
        //                {
        //                    ExisteErrorEnProceso = true;
        //                    MensajeError = "Error en el proceso de GrabarDB_SaldoxCuentasMovi";
        //                }
        //            }
        //            else
        //            {
        //                ExisteErrorEnProceso = true;
        //                MensajeError = "Error en el proceso de EliminarDB_SaldoxCuentas";
        //            }
        //        }
        //        else
        //        {
        //            ExisteErrorEnProceso = true;
        //            MensajeError = "Error en el proceso de EliminarDB_SaldoxCuentas_Movi";
        //        }



        //        //   return TodoOk;


        //    }
        //    catch (Exception ex)
        //    {
        //        ExisteErrorEnProceso = true;
        //        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_ProcesosContables_Bus) };
                
        //    }

        //}

        //public void ReversoMayorizar()
        //{
        //    try
        //    {
        //        if (_oPeriodo == null)
        //        { return; }


        //        ProcesoReversoMayorizacion(_oPeriodo);
        //    }
        //    catch (Exception ex)
        //    {
        //        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_ProcesosContables_Bus) };
        //    }
        //}

        //public void ProcesoReversoMayorizacion(ct_Periodo_Info oPeridoActualI)
        //{




        //    //------------------- calculando periodo anterior ----------------------

        //    try
        //    {


        //        ct_Periodo_Info oPeriodoActual = new ct_Periodo_Info();
        //        ct_Periodo_Info oPeriodoAnterior = new ct_Periodo_Info();
        //        ct_Periodo_Info oUltPeriodoxAnio = new ct_Periodo_Info();
        //        List<ct_Periodo_Info> ListaPeriodos = new List<ct_Periodo_Info>();
        //        ct_Periodo_Data PeD = new ct_Periodo_Data();
        //        string MensajeError = "";



        //        ListaPeriodos = PeD.Get_List_Periodo(oPeridoActualI.IdEmpresa,ref MensajeError);


        //        oPeriodoActual.IdEmpresa = oPeridoActualI.IdEmpresa;
        //        oPeriodoActual.IdanioFiscal = oPeridoActualI.IdanioFiscal;
        //        oPeriodoActual.IdPeriodo = oPeridoActualI.IdPeriodo;

        //        oPeriodoAnterior.IdEmpresa = oPeridoActualI.IdEmpresa;
        //        oPeriodoAnterior.IdanioFiscal = oPeridoActualI.IdanioFiscal;
        //        oPeriodoAnterior.IdPeriodo = oPeridoActualI.IdPeriodo;

        //        #region CalculoPeriodoAnterior




        //        var PrimerPerxAnioActu = from per in ListaPeriodos
        //                                 where per.IdEmpresa == oPeridoActualI.IdEmpresa
        //                                 && per.IdanioFiscal == oPeridoActualI.IdanioFiscal
        //                                 group per by new { per.IdEmpresa, per.IdanioFiscal }
        //                                     into grouping
        //                                     select new { grouping.Key, PrimPeriodo = grouping.Min(p => p.IdPeriodo) };





        //        var UltimoPerxAnioAnterior = from per in ListaPeriodos
        //                                     where per.IdEmpresa == oPeridoActualI.IdEmpresa
        //                                     && per.IdanioFiscal == oPeridoActualI.IdanioFiscal - 1
        //                                     group per by new { per.IdEmpresa, per.IdanioFiscal }
        //                                         into grouping
        //                                         select new { grouping.Key, UltPeriodo = grouping.Max(p => p.IdPeriodo) };





        //        foreach (var item in PrimerPerxAnioActu)
        //        {
        //            if (oPeriodoAnterior.IdPeriodo == item.PrimPeriodo) //esatdmos en el primer periodo del anio
        //            {

        //                foreach (var item2 in UltimoPerxAnioAnterior)
        //                {
        //                    oPeriodoAnterior.IdanioFiscal = item2.Key.IdanioFiscal;
        //                    oPeriodoAnterior.IdPeriodo = item2.UltPeriodo;
        //                }


        //            }
        //            else
        //            {
        //                oPeriodoAnterior.IdPeriodo = oPeriodoAnterior.IdPeriodo - 1;

        //            }


        //        }




        //        //-------------------------------------------------------------------------




        //        //-- 

        //        var DataPeriodoAnterior = from per in ListaPeriodos
        //                                  where per.IdEmpresa == oPeriodoAnterior.IdEmpresa
        //                                 && per.IdanioFiscal == oPeriodoAnterior.IdanioFiscal
        //                                 && per.IdPeriodo == oPeriodoAnterior.IdPeriodo
        //                                  select per;

        //        ct_Periodo_Info PerInfoAnterior = new ct_Periodo_Info();

        //        foreach (var item in DataPeriodoAnterior)
        //        {
        //            PerInfoAnterior.IdanioFiscal = item.IdanioFiscal;
        //            PerInfoAnterior.IdEmpresa = item.IdEmpresa;
        //            PerInfoAnterior.IdPeriodo = item.IdPeriodo;
        //            PerInfoAnterior.nom_periodo = item.nom_periodo;
        //            PerInfoAnterior.pe_cerrado = item.pe_cerrado;
        //            PerInfoAnterior.pe_estado = item.pe_estado;
        //            PerInfoAnterior.pe_FechaIni = item.pe_FechaIni;
        //            PerInfoAnterior.pe_FechaFin = item.pe_FechaFin;
        //            PerInfoAnterior.pe_mes = item.pe_mes;
        //        }

        //        #endregion




        //        //-------------- actualizar los comprobantes a no mayoriados 

        //        //-- reversando periodo actual
        //        ct_Cbtecble_Bus cb = new ct_Cbtecble_Bus();
        //        ct_Periodo_Bus PerB = new ct_Periodo_Bus();
        //        ct_Periodo_Info PerInfo = new ct_Periodo_Info();

        //        //-----------------------------------------
        //        //-----------------------------------------

        //        PerInfo.IdanioFiscal = oPeridoActualI.IdanioFiscal;
        //        PerInfo.IdEmpresa = oPeridoActualI.IdEmpresa;
        //        PerInfo.IdPeriodo = oPeridoActualI.IdPeriodo;
        //        PerInfo.nom_periodo = oPeridoActualI.nom_periodo;
        //        PerInfo.pe_cerrado = oPeridoActualI.pe_cerrado;
        //        PerInfo.pe_estado = oPeridoActualI.pe_estado;
        //        PerInfo.pe_FechaIni = oPeridoActualI.pe_FechaIni;
        //        PerInfo.pe_mes = oPeridoActualI.pe_mes;

        //        //string MensajeError = "";


        //        cb.ModificarDB_CbteMayorizado(oPeridoActualI.IdEmpresa, PerInfo.pe_FechaIni, PerInfo.pe_FechaFin, 'N', ref MensajeError);
        //        PerInfo.pe_cerrado = "N";
        //        PerB.ModificarDB(PerInfo, ref MensajeError);
        //        //-----------------------------------------
        //        //-----------------------------------------
        //        cb.ModificarDB_CbteMayorizado(oPeridoActualI.IdEmpresa, PerInfoAnterior.pe_FechaIni, PerInfoAnterior.pe_FechaFin, 'N', ref MensajeError);
        //        PerInfoAnterior.pe_cerrado = "N";
        //        PerB.ModificarDB(PerInfoAnterior, ref MensajeError);
        //        //-----------------------------------------
        //        //-----------------------------------------

                


        //        ct_saldoxCuentas_Movi_Bus oSaldoxCta_MoviB = new ct_saldoxCuentas_Movi_Bus();
        //        List<ct_saldoxCuentas_Movi_Info> ListAborrarSaldxCta_Movi = new List<ct_saldoxCuentas_Movi_Info>();
        //        ListAborrarSaldxCta_Movi = oSaldoxCta_MoviB.Get_List_saldoxCuentas_Movi_x_Periodo(PerInfo.IdEmpresa, PerInfo.IdanioFiscal, PerInfo.IdPeriodo);
        //        //oSaldoxCta_MoviB.EliminarDB_SaldoxCuentas_Movi(ListAborrarSaldxCta_Movi);
        //        oSaldoxCta_MoviB.EliminarDB_Registros_despues_del_periodo(oPeriodoActual.IdEmpresa, oPeriodoActual.IdPeriodo, ref MensajeError);




        //        ct_saldoxCuentas_Bus oSaldoxCta_B = new ct_saldoxCuentas_Bus();
        //        List<ct_SaldoxCuentas_Info> ListAborrarSaldxCta = new List<ct_SaldoxCuentas_Info>();
        //        ListAborrarSaldxCta = oSaldoxCta_B.Get_List_saldoxCuentas_x_Periodo(PerInfo.IdEmpresa, PerInfo.IdanioFiscal, PerInfo.IdPeriodo);
        //        //oSaldoxCta_B.EliminarDB_SaldoxCuentas(ListAborrarSaldxCta);
        //        oSaldoxCta_B.EliminarDB_Registros_despues_del_periodo(oPeriodoActual.IdEmpresa, oPeriodoActual.IdPeriodo, ref MensajeError);


        //    }
        //    catch (Exception ex)
        //    {
        //        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_ProcesosContables_Bus) };
        //    }
        //  }

        //public void CierreMensual()
        //{
        //    try
        //    {
        //        if (_oPeriodo == null)
        //        { return; }
        //        ProcesoCierreMensual(_oPeriodo);
        //    }
        //    catch (Exception ex)
        //    {
        //        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_ProcesosContables_Bus) };
        //    }

        //}

        //public void ProcesoCierreMensual(ct_Periodo_Info oPeridoActualI)
        //{
        //    try
        //    {
        //        string MensajeError = "";

        //        bool EsDiciembre = false;

        //          ct_Periodo_Info oPeriodoActual = new ct_Periodo_Info();
        //            ct_Periodo_Info oPeriodoSiguiente = new ct_Periodo_Info();
        //            ct_Periodo_Info oUltPeriodoxAnio = new ct_Periodo_Info();
        //            List<ct_Periodo_Info> ListaPeriodos = new List<ct_Periodo_Info>();
        //            ct_Periodo_Data PeD = new ct_Periodo_Data();

        //            ListaPeriodos = PeD.Get_List_Periodo(oPeridoActualI.IdEmpresa,ref MensajeError);

        //            oPeriodoActual.IdEmpresa = oPeridoActualI.IdEmpresa;
        //            oPeriodoActual.IdanioFiscal = oPeridoActualI.IdanioFiscal;
        //            oPeriodoActual.IdPeriodo = oPeridoActualI.IdPeriodo;


        //            oPeriodoSiguiente.IdEmpresa = oPeridoActualI.IdEmpresa;
        //            oPeriodoSiguiente.IdanioFiscal = oPeridoActualI.IdanioFiscal;
        //            oPeriodoSiguiente.IdPeriodo = oPeridoActualI.IdPeriodo;


        //            var UltPerxAnioActu = from per in ListaPeriodos
        //                                  where per.IdEmpresa == oPeridoActualI.IdEmpresa
        //                                  && per.IdanioFiscal == oPeridoActualI.IdanioFiscal
        //                                  group per by new { per.IdEmpresa, per.IdanioFiscal }
        //                                      into grouping
        //                                      select new { grouping.Key, UltiPeriodo = grouping.Max(p => p.IdPeriodo) };


        //            var PrimerPerxAnioSiguie = from per in ListaPeriodos
        //                                       where per.IdEmpresa == oPeridoActualI.IdEmpresa
        //                                       && per.IdanioFiscal == oPeridoActualI.IdanioFiscal + 1
        //                                       group per by new { per.IdEmpresa, per.IdanioFiscal }
        //                                           into grouping
        //                                           select new { grouping.Key, PriPeriodo = grouping.Min(p => p.IdPeriodo) };



        //            foreach (var item in UltPerxAnioActu)
        //            {
        //                if (oPeriodoSiguiente.IdPeriodo == item.UltiPeriodo)
        //                {

        //                    foreach (var item2 in PrimerPerxAnioSiguie)
        //                    {
        //                        oPeriodoSiguiente.IdanioFiscal = item2.Key.IdanioFiscal;
        //                        oPeriodoSiguiente.IdPeriodo = item2.PriPeriodo;
        //                    }

        //                    EsDiciembre = true;
        //                }
        //                else
        //                {
        //                    oPeriodoSiguiente.IdPeriodo = oPeriodoSiguiente.IdPeriodo + 1;
        //                    EsDiciembre = false;
        //                }

        //            }

        //            ct_saldoxCuentas_Movi_Bus SalMo = new ct_saldoxCuentas_Movi_Bus();
        //            List<ct_saldoxCuentas_Movi_Info> ListSalxCMoviActl = new List<ct_saldoxCuentas_Movi_Info>();
        //            List<ct_saldoxCuentas_Movi_Info> ListSalxCMoviSiguien = new List<ct_saldoxCuentas_Movi_Info>();

        //            #region Codigo Anterio comentado no hace falta arrastrar hacia adelante los saldos la mayorizacion ya lo hace 
                    
                    

        //            //if (EsDiciembre == true)
        //            //{
        //            //    ListSalxCMoviActl = SalMo.optenerListasaldoxCuentas_Movi_SinCtasIngEgrex_Periodo(oPeriodoActual.IdEmpresa, oPeriodoActual.IdanioFiscal
        //            //        , oPeriodoActual.IdPeriodo);
        //            //}
        //            //else
        //            //{
        //            //    ListSalxCMoviActl = SalMo.optenerListasaldoxCuentas_Movi_x_Periodo(oPeriodoActual.IdEmpresa, oPeriodoActual.IdanioFiscal
        //            //        , oPeriodoActual.IdPeriodo);
        //            //}


        //            //foreach (var item in ListSalxCMoviActl)
        //            //{
        //            //    ct_saldoxCuentas_Movi_Info oSaldoMovi = new ct_saldoxCuentas_Movi_Info();
        //            //    oSaldoMovi.IdAnioF = oPeriodoSiguiente.IdanioFiscal;
        //            //    oSaldoMovi.IdCtaCble = item.IdCtaCble;
        //            //    oSaldoMovi.IdCtaCblePadre = item.IdCtaCblePadre;
        //            //    oSaldoMovi.IdEmpresa = oPeriodoSiguiente.IdEmpresa;
        //            //    oSaldoMovi.IdPeriodo = oPeriodoSiguiente.IdPeriodo;

        //            //    oSaldoMovi.sc_credito_mes = 0;
        //            //    oSaldoMovi.sc_debito_mes = 0;

        //            //    oSaldoMovi.sc_debito_acum = item.sc_debito_acum;
        //            //    oSaldoMovi.sc_credito_acum = item.sc_credito_acum;

        //            //    oSaldoMovi.sc_saldo_acum = item.sc_saldo_acum;
        //            //    oSaldoMovi.sc_saldo_anterior = item.sc_saldo_acum;

        //            //    ListSalxCMoviSiguien.Add(oSaldoMovi);

        //            //}


        //            //SalMo.GrabarDB_SaldoxCuentasMovi(ListSalxCMoviSiguien);


        //            #endregion

        //            ct_Periodo_Bus PerB = new ct_Periodo_Bus();
        //            PerB.Modificar_Estado_CierreDB(oPeriodoActual.IdEmpresa, oPeriodoActual.IdPeriodo,"S",ref MensajeError);
        //    }
        //    catch (Exception ex)
        //    {
        //        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_ProcesosContables_Bus) };
        //    }          

        //}

        //public void CalculoSaldoInixCta()
        //{

        //    try
        //    {
        //        if (_oPeriodo == null)
        //        { return; }
        //        Procesar_y_Optener_SaldoInixCta(_oPeriodo.IdEmpresa, _oPeriodo.pe_FechaIni);
        //    }
        //    catch (Exception ex)
        //    {
        //        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_ProcesosContables_Bus) };
        //    }
        //}

        //public List<ct_saldoxCuentas_Movi_Info> Procesar_y_Optener_SaldoInixCta(int IdEmpresa, DateTime FechaCorte)
        //{
        //   try
        //    {
        //        ExisteErrorEnProceso = false;
        //        DateTime FechaIni;
        //        DateTime FechaFin;
        //        FechaIni = Convert.ToDateTime(DateTime.Now.AddYears(-50).ToShortDateString());
        //        FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());

        //        FechaFin = FechaCorte.AddDays(-1);
        //        FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());



        //        ct_Cbtecble_Bus cbB = new ct_Cbtecble_Bus();
        //        List<ct_Cbtecble_Info> lmcbi = new List<ct_Cbtecble_Info>();
        //        ct_saldoxCuentas_Movi_Bus salMoviD = new ct_saldoxCuentas_Movi_Bus();
        //        string MensajeError = "";

        //        lmcbi = cbB.Get_list_Cbtecble_ParaSaldoInicial(IdEmpresa, FechaIni, FechaFin, ref MensajeError);


        //        if (lmcbi.ToList().Count == 0)
        //        {
        //            return new List<ct_saldoxCuentas_Movi_Info>();
                
        //        }


        //        var TdebitosxCta = from Cb in lmcbi
        //                           where Cb._cbteCble_det_info.dc_Valor > 0
        //                           orderby Cb._cbteCble_det_info.IdCtaCble
        //                           group Cb by new { Cb.IdEmpresa, Cb._cbteCble_det_info.IdCtaCble }
        //                               into grouping
        //                               select new { grouping.Key, totaldebidoxCta = grouping.Sum(p => p._cbteCble_det_info.dc_Valor) };


        //        var TcreditoxCta = from Cb in lmcbi
        //                           where Cb._cbteCble_det_info.dc_Valor < 0
        //                           orderby Cb._cbteCble_det_info.IdCtaCble
        //                           group Cb by new { Cb.IdEmpresa, Cb._cbteCble_det_info.IdCtaCble }
        //                               into grouping
        //                               select new { grouping.Key, totalcreditoxCta = grouping.Sum(p => p._cbteCble_det_info.dc_Valor) * -1 };


        //        var ListaCtasCbles = from Lctas in lmcbi
        //                             orderby Lctas._cbteCble_det_info.IdCtaCble
        //                             group Lctas by new { Lctas.IdEmpresa, Lctas._cbteCble_det_info.IdCtaCble, 
        //                                 Lctas._cbteCble_det_info._Plancta_Info.IdCtaCblePadre,
        //                                 Lctas._cbteCble_det_info._Plancta_Info.pc_Naturaleza }
        //                                 into grouping
        //                                 select new { grouping.Key };




        //        double debitoMensualxCta = 0;
        //        double creditoMensualxCta = 0;


        //        List<ct_saldoxCuentas_Movi_Info> ListSaldoxCta_moviDB_Actualizado = new List<ct_saldoxCuentas_Movi_Info>();
        //        List<ct_saldoxCuentas_Movi_Info> ListSaldo_Movi = new List<ct_saldoxCuentas_Movi_Info>();


        //        foreach (var item in ListaCtasCbles)
        //        {

        //            debitoMensualxCta = 0;
        //            creditoMensualxCta = 0;




        //            var RestDebitoxCta = from C in TdebitosxCta
        //                                 where C.Key.IdEmpresa == IdEmpresa
        //                                 && C.Key.IdCtaCble.Contains(item.Key.IdCtaCble)
        //                                 select C;

        //            foreach (var itemDeb in RestDebitoxCta)
        //            {
        //                debitoMensualxCta = itemDeb.totaldebidoxCta;
        //            }


        //            var RestCreaditoxCta = from C in TcreditoxCta
        //                                   where C.Key.IdEmpresa == IdEmpresa
        //                                   && C.Key.IdCtaCble.Contains(item.Key.IdCtaCble)
        //                                   select C;

        //            foreach (var itemCred in RestCreaditoxCta)
        //            {
        //                creditoMensualxCta = itemCred.totalcreditoxCta;
        //            }

        //            //1 objeto x saldo
        //            ct_saldoxCuentas_Movi_Info SalMovi_O = new ct_saldoxCuentas_Movi_Info();
        //            SalMovi_O.IdEmpresa = item.Key.IdEmpresa;
        //            SalMovi_O.IdCtaCble = item.Key.IdCtaCble.Trim();
        //            SalMovi_O.IdCtaCblePadre = item.Key.IdCtaCblePadre.Trim();
        //            SalMovi_O.sc_debito_mes = debitoMensualxCta;
        //            SalMovi_O.sc_credito_mes = creditoMensualxCta;
        //            SalMovi_O.IdAnioF = 0;
        //            SalMovi_O.IdPeriodo = 0;
        //            ListSaldo_Movi.Add(SalMovi_O);



        //            SalMovi_O.sc_saldo_anterior = 0;
        //            //SalMovi_O.sc_debito_acum = SalMovi_O.sc_debito_mes;
        //            //SalMovi_O.sc_credito_acum = SalMovi_O.sc_credito_mes;

        //            if (item.Key.pc_Naturaleza == "D")
        //            {
        //                SalMovi_O.sc_saldo_acum = SalMovi_O.sc_debito_mes - SalMovi_O.sc_credito_mes;
        //            }
        //            else
        //            {
        //                SalMovi_O.sc_saldo_acum = (SalMovi_O.sc_credito_mes - SalMovi_O.sc_debito_mes);
        //            }

        //            ListSaldoxCta_moviDB_Actualizado.Add(SalMovi_O);
        //        }






        //        ct_rpt_SaldoxCta_Bus SaldB = new ct_rpt_SaldoxCta_Bus();
        //        List<ct_rpt_SaldoxCta_Info> listSaldoxC = new List<ct_rpt_SaldoxCta_Info>();
        //        List<ct_rpt_SaldoxCta_Info> listSaldoAEliminar = new List<ct_rpt_SaldoxCta_Info>();




        //        foreach (var item in ListSaldoxCta_moviDB_Actualizado)
        //        {

        //            ct_rpt_SaldoxCta_Info OSal = new ct_rpt_SaldoxCta_Info();
        //            OSal.IdEmpresa = item.IdEmpresa;
        //            OSal.IdCtaCble = item.IdCtaCble.Trim();
        //            OSal.sa_Creditos = 0;
        //            OSal.sa_Debitos = 0;
        //            OSal.sa_SaldoFinal = 0;
        //            OSal.sa_SaldoInicial = item.sc_saldo_acum;
        //            listSaldoxC.Add(OSal);
        //        }


        //        listSaldoAEliminar = SaldB.Get_List_SaldoxCta(IdEmpresa);
        //        SaldB.EliminarDB(listSaldoAEliminar);

        //       // SaldB.GrabarDB(listSaldoxC);



        //        return ListSaldoxCta_moviDB_Actualizado;

        //    }
        //    catch (Exception ex)
        //    {

        //        ExisteErrorEnProceso = true;
        //        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_ProcesosContables_Bus) };


        //    }

        //}


        //public List<ct_SaldoxCuentas_Info> Get_SaldoIni_x_Cta(int IdEmpresa, List<string> listCuentas, DateTime FechaCorte, ref string sMensajeError)
        //{
        //    try
        //    {


        //        ct_saldoxCuentas_Bus cbB = new ct_saldoxCuentas_Bus();
        //        List<ct_SaldoxCuentas_Info> lmcbi = new List<ct_SaldoxCuentas_Info>();

        //        lmcbi = cbB.Get_list_SaldoxCuentas_x_Periodo( IdEmpresa, listCuentas, FechaCorte, ref sMensajeError);

        //           return lmcbi;



        //    }
        //    catch (Exception ex)
        //    {
        //        ExisteErrorEnProceso = true;
        //        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_ProcesosContables_Bus) };

                

                

        //    }

        //}

        //public ct_ProcesosContables_Bus()
        //{

        //}

        //public void ProcesoMayorizar_con_sp(ct_Periodo_Info InfoPerido_Actual, string MensajeError)
        //{

        //    try
        //    {
        //        ExisteErrorEnProceso = false;
        //        string UsarMayorizar = "sys";

        //        if (InfoPerido_Actual == null)
        //        { return; }



        //        int idPeriodo = InfoPerido_Actual.IdPeriodo;
        //        int idanioF = InfoPerido_Actual.IdanioFiscal;
        //        int idEmpresa = InfoPerido_Actual.IdEmpresa;
        //        DateTime FechaIni = Convert.ToDateTime(InfoPerido_Actual.pe_FechaIni.ToShortDateString());
        //        DateTime FechaFin = Convert.ToDateTime(InfoPerido_Actual.pe_FechaFin.ToShortDateString());

        //        ct_Cbtecble_Bus cbBu = new ct_Cbtecble_Bus();
        //        List<ct_Cbtecble_Info> lmcbi = new List<ct_Cbtecble_Info>();
        //        ct_saldoxCuentas_Movi_Bus salMoviD = new ct_saldoxCuentas_Movi_Bus();

        //        List<ct_Plancta_Info> listCtasPadres = new List<ct_Plancta_Info>();
        //        ct_Plancta_Bus plB = new ct_Plancta_Bus();

        //        ct_Periodo_Bus PeriodoBus = new ct_Periodo_Bus();
        //        ct_Periodo_Info PeriodoAnteriorInfo = new ct_Periodo_Info();


        //        PeriodoAnteriorInfo = PeriodoBus.Get_Info_PeriodoAnterior(InfoPerido_Actual.IdEmpresa, InfoPerido_Actual.IdPeriodo, ref MensajeError);

        //        DateTime FechaFinCbtesNoConta = FechaIni.AddDays(-1);
        //        //FechaFinCbtesNoConta.AddDays(-1);

        //        decimal TotalCtesNoConta_PeriodoAnt = cbBu.Get_Numeros_Cbtes_no_Contabilizados(idEmpresa, new DateTime(1990, 1, 1), FechaFinCbtesNoConta, ref MensajeError);
        //        if (TotalCtesNoConta_PeriodoAnt > 0)
        //        {
        //            MensajeError = MensajeError + " No se puede Mayorizar este periodo por q el periodo anterior tiene comprobantes no mayorizados..";
        //            ExisteErrorEnProceso = true;
        //            return;
        //        }



        //        //obtengo todo el plna de cta
        //        List<ct_Plancta_Info> listPlanCtas = new List<ct_Plancta_Info>();
        //        //List<ct_Plancta_Info> listPlanCtas_a_mayorizar = new List<ct_Plancta_Info>();

        //        listPlanCtas = plB.Get_List_Plancta(idEmpresa, ref mensaje);
        //        ct_saldoxCuentas_Bus BusSaldoxCtas = new ct_saldoxCuentas_Bus();
        //        List<ct_SaldoxCuentas_Info> listSumatoria_mayorizada_x_ctas = new List<ct_SaldoxCuentas_Info>();

        //        //mayorizando 
        //        listSumatoria_mayorizada_x_ctas = BusSaldoxCtas.Get_Mayorizar_y_Optener_SaldoxCuentas(InfoPerido_Actual.IdEmpresa, InfoPerido_Actual.pe_FechaIni, InfoPerido_Actual.pe_FechaFin, UsarMayorizar, false, "", ref MensajeError);

                
        //        ct_saldoxCuentas_Bus BusSaldo_x_cuenta_perActual = new ct_saldoxCuentas_Bus();
        //        if (BusSaldo_x_cuenta_perActual.GrabarDB(listSumatoria_mayorizada_x_ctas, ref MensajeError))
        //        { 
        //            // si grabo en la base sigo
        //            cbBu.ModificarDB_CbteMayorizado(idEmpresa, FechaIni, FechaFin, 'S', ref MensajeError);
        //        }



        //    }
        //    catch (Exception ex)
        //    {
        //        ExisteErrorEnProceso = true;
        //        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_ProcesosContables_Bus) };

                
        //    }

        //}


        //public double Get_Utilidad_SaldoAnterior()
        //{
        //    try
        //    {
        //        return 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_ProcesosContables_Bus) };
        //    }
        //}

        //public double Get_Utilidad_PeriodoActual()
        //{
        //    try
        //    {
        //        return 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        oLog.Log_Error(ex.ToString());
        //        mensaje = "Error al Obtener .." + ex.Message;
        //        return 0;
        //    }
        //}

        //public double Get_Utilidad_SaldoAcumulado()
        //{
        //    try
        //    {
        //        return 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_ProcesosContables_Bus) };
        //    }
        //}


    }
}
