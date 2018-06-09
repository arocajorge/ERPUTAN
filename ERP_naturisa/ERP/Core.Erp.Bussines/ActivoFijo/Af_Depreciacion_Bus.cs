using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.ActivoFijo;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.General;

namespace Core.Erp.Business.ActivoFijo
{
    public class Af_Depreciacion_Bus
    {
        Af_Depreciacion_Data dataDepre = new Af_Depreciacion_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ct_Cbtecble_Bus CbteCbleBus = new ct_Cbtecble_Bus();
        Af_Depreciacion_x_cta_cbtecble_Bus busDepreCtaCble = new Af_Depreciacion_x_cta_cbtecble_Bus();
        

        public Boolean GuardarDB(Af_Depreciacion_Info  Info, ref decimal IdDepreciacion, ref string msjError)
        {
            try
            {
                return dataDepre.GuardarDB(Info, ref IdDepreciacion,  ref msjError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(Af_Depreciacion_Bus) };
            }
        }


        public Boolean AnularDB(Af_Depreciacion_Info Info, ct_Cbtecble_Info CbteCbleInfo, ref decimal IdCbteCble_Rev, ref string msjError)
        {
            try
            {
                if (dataDepre.AnularDB(Info, ref msjError))
                    return CbteCbleBus.ReversoCbteCble(CbteCbleInfo.IdEmpresa, CbteCbleInfo.IdCbteCble, CbteCbleInfo.IdTipoCbte, Info.IdTipoCbte_Rev, ref IdCbteCble_Rev, ref msjError, Info.IdUsuarioUltAnu, Info.MotivoAnula);
                else
                    return false;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(Af_Depreciacion_Bus) };
            }
        }

        public Boolean ModificarDB(Af_Depreciacion_Info Info, ref string msjError)
        {
            try
            {
                return dataDepre.ModificarDB(Info, ref msjError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(Af_Depreciacion_Bus) };
            }
        }

        public List<Af_Depreciacion_Info> Get_List_Depreciacion(int IdEmpresa, int IdTipoDepreciacion, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return dataDepre.Get_List_Depreciacion(IdEmpresa, IdTipoDepreciacion, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Depreciacion", ex.Message), ex) { EntityType = typeof(Af_Depreciacion_Bus) };
            }
        }

        public Af_Depreciacion_Info Get_Info_Depreciacion(int IdEmpresa, decimal IdDepreciacion, int IdTipoDepreciacion)
        {
            try
            {
                return dataDepre.Get_Info_Depreciacion(IdEmpresa, IdDepreciacion, IdTipoDepreciacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Depreciacion", ex.Message), ex) { EntityType = typeof(Af_Depreciacion_Bus) };
            }
        }

        public Boolean VerificarUltDepre(int IdEmpresa, decimal IdDepreciacion, int IdTipoDepreciacion)
        {
            try
            {
                return dataDepre.VerificarUltDepre(IdEmpresa, IdDepreciacion, IdTipoDepreciacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificarUltDepre", ex.Message), ex) { EntityType = typeof(Af_Depreciacion_Bus) };
            }
        }

        public Boolean VerificarPeriodoExistente(int IdEmpresa, int IdPeriodo, string Estado)
        {
            try
            {
                return dataDepre.VerificarPeriodoExistente(IdEmpresa, IdPeriodo, Estado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificarPeriodoExistente", ex.Message), ex) { EntityType = typeof(Af_Depreciacion_Bus) };
            }
        }


        public List<ct_Periodo_Info> get_Periodos_No_Depreciados(int IdEmpresa)
        {
            try
            {
                return dataDepre.Get_Periodos_No_Depreciados(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_Periodos_No_Depreciados", ex.Message), ex) { EntityType = typeof(Af_Depreciacion_Bus) };
            }
        }

        public List<ct_Periodo_Info> get_Periodos(int IdEmpresa)
        {
            try
            {
                return dataDepre.get_Periodos(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_Periodos_No_Depreciados", ex.Message), ex) { EntityType = typeof(Af_Depreciacion_Bus) };
            }
        }

        public Boolean ContabilizarDepreciacion(int IdEmpresa, decimal IdDepreciacion, int IdPeriodo, Cl_Enumeradores.eForma_Contabilizar sFormaContabiliza, ref  decimal IdCbteCble, ref string mensaje)
        {
            try
            {
                bool Respuesta = true;

                Af_Parametros_Bus busParam = new Af_Parametros_Bus();
                Af_Parametros_Info infoParam = new Af_Parametros_Info();
                infoParam = busParam.Get_Info_Parametros(IdEmpresa);
                int IdTipoDepreciacion = 1; // depreacion lineal

                Af_Depreciacion_x_cta_cbtecble_Info infoDepreCble = new Af_Depreciacion_x_cta_cbtecble_Info();
                List<vwAf_Valores_Depre_Contabilizar_Info> lstValoresDepre = new List<vwAf_Valores_Depre_Contabilizar_Info>();
                lstValoresDepre = get_ValoresDepreciacion(IdEmpresa, IdDepreciacion, IdTipoDepreciacion, IdPeriodo, sFormaContabiliza);
                ct_Cbtecble_Info cbtCbleInfo = new ct_Cbtecble_Info();
                cbtCbleInfo = GetCbtecble_x_Depreacion(IdEmpresa, infoParam.IdTipoCbte, IdPeriodo, lstValoresDepre,sFormaContabiliza, ref mensaje);


                Respuesta=CbteCbleBus.GrabarDB(cbtCbleInfo, ref IdCbteCble, ref mensaje);

                if (Respuesta)
                    {

                        infoDepreCble.IdEmpresa = IdEmpresa;
                        infoDepreCble.IdDepreciacion = IdDepreciacion;
                        infoDepreCble.IdTipoDepreciacion = IdTipoDepreciacion;
                        infoDepreCble.ct_IdEmpresa = cbtCbleInfo.IdEmpresa;
                        infoDepreCble.ct_IdTipoCbte = cbtCbleInfo.IdTipoCbte;
                        infoDepreCble.ct_IdCbteCble = IdCbteCble;
                        busDepreCtaCble.GuardarDB(infoDepreCble);
                    }

              return Respuesta;
             
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ContabilizarDepreciacion", ex.Message), ex) { EntityType = typeof(Af_Depreciacion_Bus) };
            }
        }

        public List<vwAf_Valores_Depre_Contabilizar_Info> get_ValoresDepreciacion
            (int IdEmpresa, decimal IdDepreciacion, int IdTipoDepreciacion, int IdPeriodo, Cl_Enumeradores.eForma_Contabilizar FormaContabiliza)
        {
            try
            {

                List<vwAf_Valores_Depre_Contabilizar_Info> ListData = new List<vwAf_Valores_Depre_Contabilizar_Info>();
                
                
                if (FormaContabiliza == Cl_Enumeradores.eForma_Contabilizar.Por_Activo)
                    ListData = dataDepre.Get_List_ValoresDepreciacion_xActivo(IdEmpresa, IdDepreciacion, IdTipoDepreciacion, IdPeriodo, FormaContabiliza);

                if (FormaContabiliza == Cl_Enumeradores.eForma_Contabilizar.Por_CtaCble)
                    ListData = dataDepre.Get_List_ValoresDepreciacion_xCtaCble(IdEmpresa, IdDepreciacion, IdTipoDepreciacion, IdPeriodo, FormaContabiliza);

                if (FormaContabiliza == Cl_Enumeradores.eForma_Contabilizar.Por_Tipo_CtaCble)
                    ListData = dataDepre.Get_List_ValoresDepreciacion_xTipo_CtaCble(IdEmpresa, IdDepreciacion, IdTipoDepreciacion, IdPeriodo, FormaContabiliza);

                return ListData;
            
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_ValoresDepreciacion", ex.Message), ex) { EntityType = typeof(Af_Depreciacion_Bus) };
            }
        }

        public ct_Cbtecble_Info GetCbtecble_x_Depreacion(int IdEmpresa, int IdTipoCbteDepre,
            int IdPeriodo, List<vwAf_Valores_Depre_Contabilizar_Info> ListInfo_data,Cl_Enumeradores.eForma_Contabilizar sFormaContabiliza ,ref string  sMensajeError)
        {
            try
            {

                ct_Cbtecble_Info CbteCbleInfo = new ct_Cbtecble_Info();
                ct_Periodo_Info InfoPeriodo = new ct_Periodo_Info();
                ct_Periodo_Bus BusPeriodo = new ct_Periodo_Bus();
                DateTime Fecha_Contab = new DateTime();

                InfoPeriodo = BusPeriodo.Get_Info_Periodo(IdEmpresa, IdPeriodo, ref sMensajeError);
                Fecha_Contab = InfoPeriodo.pe_FechaFin;


                CbteCbleInfo.IdEmpresa = IdEmpresa;
                CbteCbleInfo.IdTipoCbte = IdTipoCbteDepre;
                CbteCbleInfo.CodCbteCble = "";
                CbteCbleInfo.IdCbteCble = 0;
                CbteCbleInfo.IdPeriodo = (Fecha_Contab.Year * 100) + Fecha_Contab.Month;
                CbteCbleInfo.cb_Fecha = Fecha_Contab;
                CbteCbleInfo.cb_Valor = ListInfo_data.Where(q=>q.Valor_Depreciacion > 0).Sum(q => q.Valor_Depreciacion);
                CbteCbleInfo.cb_Observacion = "Contabilizacion " + Cl_Enumeradores.eTipoDepreciacion.DEP_LIN.ToString() + " Por " + sFormaContabiliza.ToString()  + " Periodo " + IdPeriodo;
                CbteCbleInfo.Secuencia = 0;
                CbteCbleInfo.Estado = "A";
                CbteCbleInfo.Anio = Convert.ToDateTime(CbteCbleInfo.cb_Fecha).Year;
                CbteCbleInfo.Mes = Convert.ToDateTime(CbteCbleInfo.cb_Fecha).Month;
                //CbteCbleInfo.IdUsuario = param.IdUsuario;
                CbteCbleInfo.cb_FechaTransac = DateTime.Now;
                CbteCbleInfo.Mayorizado = "N";


                List<ct_Cbtecble_det_Info> lstDetalle = new List<ct_Cbtecble_det_Info>();

                List<Af_Activo_fijo_CtasCbles_Info> ListInfo_Activos_x_ctas = new List<Af_Activo_fijo_CtasCbles_Info>();
                Af_Activo_fijo_CtasCbles_Bus BusAf_x_ctaCbles = new Af_Activo_fijo_CtasCbles_Bus();
                ListInfo_Activos_x_ctas = BusAf_x_ctaCbles.Get_List_Activo_fijo_CtasCbles(IdEmpresa);

                Af_Parametros_Info info_param_af = new Af_Parametros_Info();
                Af_Parametros_Bus bus_param_af = new Af_Parametros_Bus();
                info_param_af = bus_param_af.Get_Info_Parametros(IdEmpresa);

                #region Contabilización x activo
                foreach (var item_x_data in ListInfo_data)
                {

                    List<Af_Activo_fijo_CtasCbles_Info> ListInfo_Af_x_ctas = new List<Af_Activo_fijo_CtasCbles_Info>();

                    if (info_param_af.FormaContabiliza == Cl_Enumeradores.eForma_Contabilizar.Por_Activo.ToString())
                        ListInfo_Af_x_ctas = ListInfo_Activos_x_ctas.Where(v => v.IdEmpresa == IdEmpresa && v.IdActivoFijo == item_x_data.IdActivoFijo).ToList();

                    if (info_param_af.FormaContabiliza == Cl_Enumeradores.eForma_Contabilizar.Por_CtaCble.ToString())
                    {
                        
                    }

                    if (info_param_af.FormaContabiliza == Cl_Enumeradores.eForma_Contabilizar.Por_Tipo_CtaCble.ToString())
                        ListInfo_Af_x_ctas = ListInfo_Activos_x_ctas.Where(v => v.IdEmpresa == IdEmpresa && v.IdActijoFijoTipo == item_x_data.IdActijoFijoTipo).ToList();

                    vwAf_Valores_Depre_Contabilizar_Info Info_valores_depre_con_x_Gasto_depre = new vwAf_Valores_Depre_Contabilizar_Info();
                    Info_valores_depre_con_x_Gasto_depre = item_x_data;



                    //////////////////////////////
                    var q_Gastos_x_depre = from C in ListInfo_Af_x_ctas
                                           where C.IdTipoCuenta == "CTA_GASTOS_DEPRE"
                                           group C by new { C.IdEmpresa, C.IdTipoCuenta, C.IdCtaCble, C.porc_distribucion }
                                               into grouping
                                               select new { grouping.Key, Total_reg = grouping.Count() };


                    if (q_Gastos_x_depre.Count() == 1) // solo hay una cuenta x CTA_GASTOS_DEPRE
                    {
                        foreach (var item_x_cta in q_Gastos_x_depre)
                        {
                            Info_valores_depre_con_x_Gasto_depre.IdCtaCbleGastos = item_x_cta.Key.IdCtaCble;
                            Info_valores_depre_con_x_Gasto_depre.Valor_a_contabilizar = item_x_data.Valor_Depreciacion;
                        }
                    }
                    else// mas de una cta distribuir por %
                    {
                        foreach (var item_x_cta in q_Gastos_x_depre)
                        {
                            Info_valores_depre_con_x_Gasto_depre.IdCtaCbleGastos = item_x_cta.Key.IdCtaCble;
                            Info_valores_depre_con_x_Gasto_depre.Valor_a_contabilizar = (item_x_data.Valor_Depreciacion * item_x_cta.Key.porc_distribucion) / 100;
                        }
                    }

                    ///
                    
                    //////////////////////////////
                    ///////// Info_valores_depre_con_x_depre_Acum
                    vwAf_Valores_Depre_Contabilizar_Info Info_valores_depre_con_x_depre_Acum = new vwAf_Valores_Depre_Contabilizar_Info();
                    Info_valores_depre_con_x_depre_Acum = item_x_data;

                    var q_depre_Acumulada = from C in ListInfo_Af_x_ctas
                                            where C.IdTipoCuenta == "CTA_DEPRE_ACUM"
                                            group C by new { C.IdEmpresa, C.IdTipoCuenta, C.IdCtaCble, C.porc_distribucion }
                                                into grouping
                                                select new { grouping.Key, Total_reg = grouping.Count() };


                    if (q_depre_Acumulada.Count() == 1) // solo hay una cuenta x CTA_DEPRE_ACUM
                    {
                        foreach (var item_x_cta in q_depre_Acumulada)
                        {
                            Info_valores_depre_con_x_depre_Acum.IdCtaCbleDepre = item_x_cta.Key.IdCtaCble;
                            Info_valores_depre_con_x_depre_Acum.Valor_a_contabilizar = item_x_data.Valor_Depreciacion;
                        }
                    }
                    else// mas de una cta distribuir por %
                    {
                        foreach (var item_x_cta in q_depre_Acumulada)
                        {
                            Info_valores_depre_con_x_depre_Acum.IdCtaCbleDepre = item_x_cta.Key.IdCtaCble;
                            Info_valores_depre_con_x_depre_Acum.Valor_a_contabilizar = (item_x_data.Valor_Depreciacion * item_x_cta.Key.porc_distribucion) / 100;
                        }
                    }



                    
                    ct_Cbtecble_det_Info infoDetalle = new ct_Cbtecble_det_Info();

                    infoDetalle = new ct_Cbtecble_det_Info();
                    infoDetalle.IdEmpresa = IdEmpresa;
                    infoDetalle.IdTipoCbte = IdTipoCbteDepre;
                    infoDetalle.IdCtaCble = Info_valores_depre_con_x_Gasto_depre.IdCtaCbleGastos;
                    infoDetalle.dc_Valor = Info_valores_depre_con_x_Gasto_depre.Valor_a_contabilizar;
                    infoDetalle.dc_Observacion = CbteCbleInfo.cb_Observacion;
                    infoDetalle.secuencia = 1;
                    lstDetalle.Add(infoDetalle);

                    //datos el haber
                    infoDetalle = new ct_Cbtecble_det_Info();
                    infoDetalle.IdEmpresa = IdEmpresa;
                    infoDetalle.IdTipoCbte = IdTipoCbteDepre;
                    infoDetalle.IdCtaCble = Info_valores_depre_con_x_depre_Acum.IdCtaCbleDepre;
                    infoDetalle.dc_Valor = Info_valores_depre_con_x_depre_Acum.Valor_a_contabilizar  * -1;
                    infoDetalle.dc_Observacion = CbteCbleInfo.cb_Observacion;
                    infoDetalle.secuencia = 2;
                    lstDetalle.Add(infoDetalle);

                    
                }


                CbteCbleInfo._cbteCble_det_lista_info = lstDetalle;
                    #endregion


                return CbteCbleInfo;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ContabilizarDepreciacion", ex.Message), ex) { EntityType = typeof(Af_Depreciacion_Bus) };
            }
        }

        
        public Af_Depreciacion_Bus()
        {

        }
    }
}
