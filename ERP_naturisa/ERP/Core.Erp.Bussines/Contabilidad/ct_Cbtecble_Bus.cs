using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Business.Bancos;

namespace Core.Erp.Business.Contabilidad
{


    public class ct_Cbtecble_Bus
    {        
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_Conciliacion_det_IngEgr_Bus bus_Conci_bancaria = new ba_Conciliacion_det_IngEgr_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ct_Cbtecble_det_Data data_det = new ct_Cbtecble_det_Data();
        ct_Cbtecble_Data data = new ct_Cbtecble_Data();

        public Boolean ModificarDB_CbteMayorizado(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, char Mayorizado,ref string  MensajeError)
        {
            try
            {

                return false;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB_CbteMayorizado", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_Bus) };
            }

        }

        public Boolean ReversoCbteCble(int IdEmpresa, decimal idcbtecble, int idtipocble, int idtipocble_rev,
            ref decimal idcbtecble_rev, ref string msg, string user,string MotivoAnulacion ="")
        {
            try
            {
                Boolean respuesta=true;

                ct_cbtecble_Reversado_Data _dataReversado = new ct_cbtecble_Reversado_Data();
                ct_cbtecble_Reversado_Info _InfoReversado = new ct_cbtecble_Reversado_Info();

                _InfoReversado =_dataReversado.Get_CbteCble_Reversado_Info(IdEmpresa, idtipocble, idcbtecble);

                if (_InfoReversado.IdCbteCble_Anu == 0)//no esta reversado se puede reversar
                {
                    respuesta = data.ReversoCbteCble(IdEmpresa, idcbtecble, idtipocble, idtipocble_rev, ref idcbtecble_rev,
                    ref msg, param.IdUsuario, MotivoAnulacion, param.Fecha_Transac.ToString());
                }
                else
                { 
                    respuesta=true;

                }

                return respuesta;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ReversoCbteCble", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_Bus) };
            }
        }

        public List<ct_Cbtecble_Info> Get_list_Cbtecble(int IdEmpresa, ref string MensajeError)
        {
            List<ct_Cbtecble_Info> lm = new List<ct_Cbtecble_Info>();


            try
            {
                lm = data.Get_list_Cbtecble(IdEmpresa, ref MensajeError);
                return (lm);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Cbtecble", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_Bus) };
            }
        }

        public List<ct_Cbtecble_Info> Get_list_Cbtecble_ParaSaldoInicial(int IdEmpresa, DateTime iFechaIni, DateTime iFechaFin, ref string MensajeError)
        {

            
            List<ct_Cbtecble_Info> lM = new List<ct_Cbtecble_Info>();
            try
            {
                lM = data.Get_list_Cbtecble_ParaSaldoInicial(IdEmpresa, iFechaIni, iFechaFin, ref MensajeError);
                return lM;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Cbtecble_ParaSaldoInicial", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_Bus) };
            }

        }

        public List<ct_Cbtecble_Info> Get_list_Cbtecble(int IdEmpresa, DateTime iFechaIni, DateTime iFechaFin,
            int IdCbteCble1, string CodCbteCble1, string IdTipoCbte1, string observacion, string IdUsuario, ref string MensajeError)
              {
                  try
                  {
                        
                            List<ct_Cbtecble_Info> lM = new List<ct_Cbtecble_Info>();
                            lM = data.Get_list_Cbtecble(IdEmpresa, iFechaIni, iFechaFin, IdCbteCble1,
                                CodCbteCble1, IdTipoCbte1, observacion, IdUsuario, ref MensajeError);
                            return lM;
                  }
                  catch (Exception ex)
                  {
                      Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                      throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Cbtecble", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_Bus) };
                  }
        }

        public List<ct_Cbtecble_Info>Get_list_Cbtecble(int IdEmpresa, DateTime iFechaIni, DateTime iFechaFin,
        decimal IdCbteCbleIni, decimal IdCbteCbleFin, string CodCbteCble, int IdTipoCbteIni,
            int IdTipoCbteFin, string observacion, string IdUsuario, ref string MensajeError)
        {
            try
            {
               
                List<ct_Cbtecble_Info> lM = new List<ct_Cbtecble_Info>();

                lM = data.Get_list_Cbtecble(IdEmpresa, iFechaIni, iFechaFin, IdCbteCbleIni,
                    IdCbteCbleFin, CodCbteCble, IdTipoCbteIni, IdTipoCbteFin, observacion, IdUsuario, ref MensajeError);
                return lM;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Cbtecble", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_Bus) };
            }

        }

        public decimal Get_IdCbteCble(int IdEmpresa, int idTipoCbte, ref string MensajeError)
        {
            decimal IdcbteCble;
            
            try 
	        {
                IdcbteCble = data.Get_IdCbteCble(IdEmpresa, idTipoCbte, ref MensajeError);
                return IdcbteCble;
	        }
	        catch (Exception ex)
	        {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_IdCbteCble", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_Bus) };
	        }
            
        }

        public decimal Get_IdSecuencia(ref string MensajeError)
        {
            decimal IdSecuencia;
            try
            {

                IdSecuencia = data.Get_IdSecuencia(param.IdEmpresa, ref MensajeError);
                return IdSecuencia;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_IdSecuencia", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_Bus) };
            }
            
        }

        public DateTime Get_fecha_min_cbtes_no_Contabilizados(int IdEmpresa, DateTime fecha_Ini, DateTime fecha_fin, ref string MensajeError)
        {
            try
            {

                return data.Get_fecha_min_cbtes_no_Mayorizado(IdEmpresa, fecha_Ini, fecha_fin, ref MensajeError);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_fecha_min_cbtes_no_Mayorizado", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_Bus) };
            }
        }

        public decimal Get_Numeros_Cbtes_no_Contabilizados(int IdEmpresa, DateTime fecha_Ini, DateTime fecha_Fin, ref string MensajeError)
        {

            try
            {

                return data.Get_Numeros_Cbtes_no_Contabilizados(IdEmpresa, fecha_Ini,fecha_Fin, ref MensajeError);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Numeros_Cbtes_no_Contabilizados", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_Bus) };
            }
        }

        public List<ct_Cbtecble_Info> Get_list_Cbtecble_ParaMayorizar(int IdEmpresa, DateTime iFechaIni, DateTime iFechaFin, ref string MensajeError)
        {
           try
            {
                List<ct_Cbtecble_Info> lM = new List<ct_Cbtecble_Info>();
                lM = data.Get_list_Cbtecble_ParaMayorizar(IdEmpresa, iFechaIni, iFechaFin, ref MensajeError);
                return lM;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Cbtecble_ParaMayorizar", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_Bus) };
            }
        }

        public List<ct_Cbtecble_Info> Get_list_Cbtecble_Pendientes_ParaMayorizacion(int IdEmpresa,
            DateTime iFechaIni, DateTime iFechaFin, ref string MensajeError)
        {

            try
            {
                
                List<ct_Cbtecble_Info> lM = new List<ct_Cbtecble_Info>();
                lM = data.Get_list_Cbtecble_Pendientes_ParaMayorizacion(IdEmpresa, iFechaIni, iFechaFin, ref MensajeError);
                return lM;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Cbtecble_Pendientes_ParaMayorizacion", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_Bus) };
            }


        }


        public Boolean Actualizar_Observacion(ct_Cbtecble_Info _CbteCbleInfo, ref string MensajeError)
        {
            try
            {
                return data.Actualizar_Observacion(_CbteCbleInfo, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_Bus) };
            }

        }

        
        public Boolean ModificarDB(ct_Cbtecble_Info _CbteCbleInfo, ref string MensajeError)
        {
            
            try
            {
                bool res = false;

                if (!ValidarObjeto(_CbteCbleInfo, ref  MensajeError))
                    return false;
                //Valido si la cabecera esta conciliada
                if (!bus_Conci_bancaria.Cbte_existe_en_conciliacion(_CbteCbleInfo.IdEmpresa, _CbteCbleInfo.IdTipoCbte, _CbteCbleInfo.IdCbteCble))
                    res = data.ModificarDB(_CbteCbleInfo, ref MensajeError);
                else
                {
                    //Si modifica cabecera, modifico uno a uno los detalles
                    if (data.Modificar_cabecera(_CbteCbleInfo))
                    {
                        foreach (var item in _CbteCbleInfo._cbteCble_det_lista_info)
                        {
                            // Elimino todas las lineas que no sean de la conciliacion
                            if (!bus_Conci_bancaria.Cbte_existe_en_conciliacion(item.IdEmpresa, item.IdTipoCbte, item.IdCbteCble, item.secuencia))
                            { if (!data_det.ModificarDB(item, ref MensajeError)) { return false; } }
                            else
                            {
                                if (!data_det.ModificarDB_conciliado(item, ref MensajeError)) { return false; } 
                            }
                        }
                        
                        res = true;
                    }
                }
                return res;
            }
            catch(Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_Bus) };
            }

        }

        public Boolean Eliminar(ct_Cbtecble_Info _CbteCbleInfo,ref string MensajeError)
        {
            try
            {

                return data.EliminarDB(_CbteCbleInfo, ref MensajeError);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_Bus) };
            }
        }

        public Boolean GrabarDB(ct_Cbtecble_Info _CbteCbleInfo, ref decimal IdCbteCble, ref string MensajeError)
        {
            try
            {
                string codigo = "";

                if (!ValidarObjeto(_CbteCbleInfo, ref  MensajeError))
                    return false;
                return data.GrabarDB(_CbteCbleInfo, ref IdCbteCble, ref codigo, ref MensajeError);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_Bus) };
            }
        }        

        public ct_Cbtecble_Info Get_Info_CbteCble(int IdEmpresa, int IdTipoCbte, decimal IdCbteCbl, ref string MensajeError)
        {
            try
            {

                return data.Get_Info_CbteCble(IdEmpresa, IdTipoCbte, IdCbteCbl, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_CbteCble", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_Bus) };
            }

        }

        public Boolean ValidarObjeto(ct_Cbtecble_Info Info_CbteCble, ref string MensajeError)
        {
           
            try
            {

                Boolean res = true;


                if (Info_CbteCble.IdEmpresa == 0 || Info_CbteCble.IdTipoCbte==0  )
                {
                    MensajeError = "el objeto esta errado los PK IdEmpresa , IdTipoCbte no pueden estar en cero";
                    res = false;
                    return res;
                }

                if (Info_CbteCble._cbteCble_det_lista_info == null)
                {
                    MensajeError = "El Comprobante no tiene detalle";
                    res = false;
                    return res;
                }

                try
                {
                    Info_CbteCble.cb_Valor = Info_CbteCble._cbteCble_det_lista_info.FindAll(q => q.dc_Valor > 0).Sum(q => q.dc_Valor);
                }
                catch (Exception ex)
                {
                    oLog.Log_Error(ex.ToString());
                    Info_CbteCble.cb_Valor = 0;
                }
                if (Info_CbteCble.cb_Valor == 0)
                {
                    MensajeError = "El Valor del Comprobante contable no puede ser 0.";
                    return false;
                    
                }

                if ( Info_CbteCble.IdPeriodo == 0)
                {
                    MensajeError = "Periodo Fiscal es invalido, por favor verifique.";
                    res =false;
                }


                if (Info_CbteCble.IdSucursal == 0)
                {
                    tb_Sucursal_Bus busSucu = new tb_Sucursal_Bus();
                    Info_CbteCble.IdSucursal  =busSucu.Get_List_Sucursal(Info_CbteCble.IdEmpresa).FirstOrDefault().IdSucursal;
                   
                }

               

                if (Info_CbteCble.cb_Fecha == (new DateTime()))
                {
                    MensajeError = "Fecha de comprobante es invalida, por favor verifique.";
                    res = false;
                }

                

                foreach (var item in Info_CbteCble._cbteCble_det_lista_info)
                {
                    item.IdEmpresa = Info_CbteCble.IdEmpresa;
                    item.IdCbteCble = Info_CbteCble.IdCbteCble;
                    item.dc_Valor = Math.Round(item.dc_Valor, 2, MidpointRounding.AwayFromZero);
                }
                // realizo una sumatoria del debe y haber para obtener la diferencia
                Info_CbteCble._cbteCble_det_lista_info.ForEach(x => x.dc_Valor = Math.Round(x.dc_Valor, 3));



                var Sum_Total_debito = (from tb in Info_CbteCble._cbteCble_det_lista_info where tb.dc_Valor>0
                             select tb.dc_Valor ).Sum();

                var Sum_Total_credito = (from tb in Info_CbteCble._cbteCble_det_lista_info
                                        where tb.dc_Valor < 0
                                        select tb.dc_Valor).Sum();


                double Total_Debito = Math.Round(Convert.ToDouble(Convert.ToString(Sum_Total_debito)), 2, MidpointRounding.AwayFromZero);
                double Total_Credito = Math.Round(Convert.ToDouble(Convert.ToString(Sum_Total_credito)), 2, MidpointRounding.AwayFromZero);

                double Diferencia = Total_Debito + Total_Credito;
                Diferencia = Math.Round(Diferencia, 2, MidpointRounding.AwayFromZero);
                if (Diferencia >= -0.02 || Diferencia <= 0.02)//Se cambio a 2 ctvs porque  
                {
                    if (Diferencia > 0)// 1 ctv de mas
                    {
                        Info_CbteCble._cbteCble_det_lista_info.FirstOrDefault(v => v.dc_Valor > 0).dc_Valor -= Diferencia;// le resto 1
                    }
                    else 
                    {
                        Info_CbteCble._cbteCble_det_lista_info.FirstOrDefault(v => v.dc_Valor < 0).dc_Valor -= Diferencia;// le resto a los negativos
                    }
                    Diferencia = 0; 
                }

                if (Convert.ToDouble(Convert.ToString(Diferencia)) != 0)  // si es diferente de 0 quiere decir q no esta cuadrado el CBTE CBLE
                {
                    MensajeError = "El Diaro no esta cuadrado Hay difencias entre el debito y el credito:  Total Debito:" + Total_Debito + " Total Credito:" + Total_Credito + " Diferencia:" + Diferencia;
                    res = false;
                    return res;
                }

                double TotalCbte = 0;


                foreach (var item in Info_CbteCble._cbteCble_det_lista_info)
                {
                    if (item.IdCtaCble == null || item.IdCtaCble == "")
                    {
                        MensajeError = "Falta Cuenta Contable en detalle " + item.dc_Observacion;
                        res = false;
                        return res;
                    }
                    if (item.dc_Valor == 0)
                    {
                        MensajeError = "Existen detalles con valor 0, verifique por favor.";
                        res = false;
                        return res;
                    }
                    if (item.dc_Valor > 0) { TotalCbte = TotalCbte + item.dc_Valor; }
                }

                Info_CbteCble.cb_Fecha = Convert.ToDateTime(Info_CbteCble.cb_Fecha.ToShortDateString());
                if (Info_CbteCble.cb_Valor == 0) { Info_CbteCble.cb_Valor =Math.Round( TotalCbte,2); };



                if (res == false)
                {  oLog.Log_Error(MensajeError); }
                
                return res;    


            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarObjeto", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_Bus) };
            }
            
        
        }
        
        public ct_Cbtecble_Bus() {
            
        }

    }
}
