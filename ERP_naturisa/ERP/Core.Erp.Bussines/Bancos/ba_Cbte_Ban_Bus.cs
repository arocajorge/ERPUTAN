using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Bancos;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Bancos
{
    public class ba_Cbte_Ban_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_Cbte_Ban_Data data = new ba_Cbte_Ban_Data();
        ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();

        private Boolean validar_objeto(ba_Cbte_Ban_Info Info, ref string mensaje1)
        {
            try
            {
               

                if (Info.IdSucursal == 0)
                {
                    tb_Sucursal_Bus BusSucursal = new tb_Sucursal_Bus();
                    List<tb_Sucursal_Info> List_InfoSucu = new List<tb_Sucursal_Info>();
                    List_InfoSucu=BusSucursal.Get_List_Sucursal(Info.IdEmpresa);
                    Info.IdSucursal = List_InfoSucu.FirstOrDefault().IdSucursal;
                }

                if (Info.IdEstado_Cbte_Ban_cat == "" && Info.IdEstado_Cbte_Ban_cat == null)
                {
                    ba_Catalogo_Bus BusCata_Ban = new ba_Catalogo_Bus();
                    List<ba_Catalogo_Info> listCatalogo = new List<ba_Catalogo_Info>();
                    listCatalogo = BusCata_Ban.Get_List_Estado_Cbte_ban();
                    Info.IdEstado_Cbte_Ban_cat = listCatalogo.FirstOrDefault().IdCatalogo;
                }


                if (Info.IdEmpresa == 0)
                {
                    mensaje1 = "Hay un error en el Idempresa=" + Info.IdEmpresa + " IdSucursal=" + Info.IdSucursal;
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "validar_objeto", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_Bus) };
            }
        }

        public List<ba_Cbte_Ban_Info> Get_List_Cbte_Ban(int IdEmpresa, int IdTipocbteIni, int IdTipocbteFin, DateTime F_inicio, DateTime F_fin, ref string MensajeError)
        {
            try
            {
                return data.Get_List_Cbte_Ban(IdEmpresa, IdTipocbteIni, IdTipocbteFin, F_inicio, F_fin, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cbte_Ban", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_Bus) };
            }

        }

        public ba_Cbte_Ban_Info Get_Info_Cbte_Ban(int IdEmpresa, int IdTipocbte,decimal IdCbteCble , ref string MensajeError)
        {
            try
            {
                return data.Get_Info_Cbte_Ban(IdEmpresa, IdTipocbte, IdCbteCble, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cbte_Ban", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_Bus) };
            }
        }

        //public List<ba_Cbte_Ban_Info> Get_List_CbtBancoReport(int IdEmpresa, decimal IdCbteCble, int IdTipoCbte, ref string MensajeError)
        //{
        //    try
        //    {
        //        return new List<ba_Cbte_Ban_Info>();
        //    }
        //    catch (Exception ex) 
        //    {
        //        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_CbtBancoReport", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_Bus) };
        //    }

        //}
       
        public Boolean GrabarDB(ba_Cbte_Ban_Info info, ref string MensajeError)
        {
            try
            {
                Boolean respuesta=false;

                respuesta=validar_objeto(info,ref MensajeError);

                if (respuesta)
                {
                    respuesta = data.GrabarDB(info, ref  MensajeError);
                }
                return respuesta;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_Bus) };
            }

        }

        public Boolean AnularDB(ba_Cbte_Ban_Info info, ref string MensajeError)
        {
            try
            {
                   return data.AnularDB(info,ref  MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarEstado", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_Bus) };
            }

        }
        
        public Boolean ActualizarUltimocheque(ba_Cbte_Ban_Info info, ref string MensajeError)
        {
            try
            {
              return data.ActualizarUltimocheque(info,ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarUltimocheque", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_Bus) };
            }

        }

         public Boolean ActualizarObservacion(ba_Cbte_Ban_Info info, ref string MensajeError)
        {
            try
            {

                Boolean res = false;

                res =data.ActualizarObservacion(info, ref MensajeError);
                if (res == true)
                {
                    ct_Cbtecble_Bus BusCbteCble = new ct_Cbtecble_Bus();
                    ct_Cbtecble_Info InfoCbteCble = new ct_Cbtecble_Info();
                    InfoCbteCble.IdEmpresa = info.IdEmpresa;
                    InfoCbteCble.IdTipoCbte = info.IdTipocbte;
                    InfoCbteCble.IdCbteCble = info.IdCbteCble;
                    InfoCbteCble.cb_Observacion = info.cb_Observacion;
                    res = BusCbteCble.Actualizar_Observacion(InfoCbteCble, ref MensajeError);
                }

                return res;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarUltimocheque", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_Bus) };
            }

        }

        public Boolean ModificarDB(ba_Cbte_Ban_Info info, ref string MensajeError)
        {
            try
            {

                Boolean respuesta = false;

                respuesta = validar_objeto(info, ref MensajeError);

                if (respuesta)
                {
                    respuesta = data.ModificarDB(info, ref  MensajeError);
                    
                    if (respuesta)
                    {
                        ct_Cbtecble_Bus BusCbteCble = new ct_Cbtecble_Bus();
                        BusCbteCble.ModificarDB(info.info_Cbtecble, ref MensajeError);
                     }
                    
                }
                return respuesta;


            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_Bus) };
            }

        }
       
        public Boolean VericarChequeExiste(string cheque, int IdEmpresa, decimal IdCbteCble, int IdTipoCbte, int IdBanco, ref string mensaje)
        {
            try
            {
            return data.VericarChequeExiste(cheque, IdEmpresa, IdCbteCble, IdTipoCbte, IdBanco, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VericarChequeExiste", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_Bus) };
            }
        }

        //public ba_rpt_ChequeComprobante_Info Get_ChequeComprobante_Rpt(int IdEmpresa, decimal IdCbteCble, int IdTipoCbte, ref string MensajeError)
        //{
        //    try
        //    {
        //        return data.Get_ChequeComprobante_Rpt(IdEmpresa, IdCbteCble, IdTipoCbte,ref MensajeError);
        //    }
        //    catch (Exception ex)
        //    {
        //        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_ChequeComprobante_Rpt", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_Bus) };
        //    }

        //}

        public List<cxc_cobro_Info> Get_List_CobrosDepositados(int IdEmpresa, decimal IdCbteCble, int IdTipoCbte, ref string MensajeError)
        {
            try
            {
               return data.Get_List_CobrosDepositados(IdEmpresa, IdCbteCble, IdTipoCbte,ref  MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_CobrosDepositados", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_Bus) };
            }
        
        }
        
        public List<ba_Cbte_Ban_Info> Get_List_X_NotasMasivas(List<ba_notasDebCre_masivo_Info> ListCbtMasivo, ref string MensajeError)
        {
            try
            {
                   return data.Get_List_X_NotasMasivas(ListCbtMasivo,ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_X_NotasMasivas", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_Bus) };
            }

        }

        public List<ba_Cbte_Ban_Info> Get_List_Cbte_Ban(int IdEmpresa, DateTime FechaInicio, DateTime FechaFin, ref string MensajeError)
        {
            try
            {
                return data.Get_List_Cbte_Ban(IdEmpresa, FechaInicio, FechaFin,ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cbte_Ban", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_Bus) };
            }

        }

        public Boolean VerificarExisteRegistroImportacion(string IdHash, ref string MensajeError)
        {
            try
            {
               return data.VerificarExisteRegistroImportacion(IdHash,ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificarExisteRegistroImportacion", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_Bus) };
            }

        }

        public List<vwba_Banco_Movimiento_det_cancelado_Info> Get_List_Cancelada(int IdEmpresa, decimal IdCbteCble, int IdTipocbte, ref string MensajeError)
        {
            try
            {
                 return data.Get_List_Cancelada(IdEmpresa, IdCbteCble, IdTipocbte,ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cancelada", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_Bus) };
            }

        }

        public List<vwcp_orden_pago_con_cancelacion_x_CbteBan_Debi_Info> Get_List_CanceladaNotaDebCred(int IdEmpresa, decimal IdCbteCble, int IdTipocbte, ref string MensajeError)
        {
            try
            {
                return data.Get_List_CanceladaNotaDebCred(IdEmpresa, IdCbteCble, IdTipocbte,ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_CanceladaNotaDebCred", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_Bus) };
            }

        }


        public List<ba_Cbte_Ban_Info> Get_List_Cbte_Ban(int IdEmpresa, int IdTipocbteBan, DateTime F_inicio, DateTime F_fin,
            string IdEstado_Preaviso_ch_cat, ref string MensajeError)
        {
            try
            {
                return data.Get_List_Cbte_Ban(IdEmpresa, IdTipocbteBan ,F_inicio,F_fin,IdEstado_Preaviso_ch_cat, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cbte_Ban", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_Bus) };
            }

        }

        public List<ba_Cbte_Ban_Info> Get_List_Cbte_Ban(int IdEmpresa, int idSucursalIni, int idSucursalFin, DateTime FechaIni, DateTime FechaFin, string idCbte_Tipo, int idBancoIni, int idBancoFin, string idCbte_ban_Estado, ref string MensajeError)
        {
            try
            {
                return data.Get_List_Cbte_Ban(IdEmpresa, idSucursalIni, idSucursalFin, FechaIni, FechaFin, idCbte_Tipo, idBancoIni, idBancoFin, idCbte_ban_Estado, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cbte_Ban", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_Bus) };
            }

        }


        public Boolean Modificar_Estado_Preaviso_ch(List<ba_Cbte_Ban_Info> Lista,eEstado_Preaviso_Cheque IdEstado_Preaviso, ref string MensajeError)
        {
            try
            {
                return data.Modificar_Estado_Preaviso_ch(Lista, IdEstado_Preaviso, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar_Estado_cbte_ban", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_Bus) };
            }

        }
        
        public Boolean Modificar_Estado_cbte_ban(List<ba_Cbte_Ban_Info> Lista, ref string MensajeError)
        {
            try
            {
                return data.Modificar_Estado_cbte_ban(Lista, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar_Estado_cbte_ban", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_Bus) };
            }
        }

        public Boolean Modificar_estado_Cheq(ba_Cbte_Ban_Info info, eEstado_Cheque Estado, ref string MensajeError)
        {
            try
            {

                return data.Modificar_estado_Cheq(info, Estado, ref  MensajeError);                 

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_Bus) };
            }

        }

        public Boolean Modificar_tipo_flujo(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble, Nullable<decimal> IdTipoFlujo)
        {
            try
            {
                return data.Modificar_tipo_flujo(IdEmpresa, IdTipoCbte, IdCbteCble, IdTipoFlujo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar_tipo_flujo", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_Bus) };
            }
        }

        public ba_Cbte_Ban_Bus()
        {

        }
    }
}
