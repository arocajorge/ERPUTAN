using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Data.General;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using System.Data.Objects;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using System.Data.Entity.Validation;


namespace Core.Erp.Data.Bancos
{
    public class ba_Cbte_Ban_Data
    {


        public ba_Cbte_Ban_Info Get_Info_Cbte_Ban(int IdEmpres, int IdTipocbte,decimal IdCbteCble , ref string MensajeError)
        {
                
                EntitiesBanco b = new EntitiesBanco();
                ba_Cbte_Ban_Info dat_ = new ba_Cbte_Ban_Info();
            try
            {
                var select_ = from T in b.vwba_Cbte_Ban
                              where T.IdEmpresa == IdEmpres 
                              && T.IdTipocbte == IdTipocbte
                              && T.IdCbteCble ==IdCbteCble
                              select T;
             foreach (var item in select_)
                {
                    
                    dat_.IdEmpresa = item.IdEmpresa;
                    dat_.IdCbteCble = item.IdCbteCble;
                    dat_.IdTipocbte = item.IdTipocbte;
                    dat_.Cod_Cbtecble = item.Cod_Cbtecble;
                    dat_.IdPeriodo = item.IdPeriodo;
                    dat_.IdBanco = item.IdBanco;
                    dat_.cb_Fecha = item.cb_Fecha;
                    dat_.cb_Observacion = item.cb_Observacion;
                    dat_.cb_secuencia = item.cb_secuencia;
                    dat_.cb_Valor = item.cb_Valor;
                    dat_.cb_Cheque = item.cb_Cheque;
                    dat_.cb_ChequeImpreso = item.cb_ChequeImpreso;
                    dat_.cb_FechaCheque = item.cb_FechaCheque;
                    dat_.FechaAnulacion = item.FechaAnulacion;
                    dat_.ip = item.ip;
                    dat_.nom_pc = item.nom_pc;
                    dat_.cb_giradoA = item.cb_giradoA;
                    dat_.IdUsuario = item.IdUsuario;
                    dat_.IdUsuario_Anu = item.IdUsuario_Anu;
                    dat_.Fecha_Transac = item.Fecha_Transac;
                    dat_.Fecha_UltMod = item.Fecha_UltMod;
                    dat_.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    dat_.Estado = item.Estado;
                    dat_.MotivoAnulacion = item.MotivoAnulacion;
                    dat_.cb_ciudadChq = item.cb_ciudadChq;
                    dat_.Tipo = item.tc_TipoCbte;
                    dat_.Banco = item.ba_descripcion;
                    
                    dat_.IdProveedor = item.IdProveedor;
                    dat_.IdCbteCble_Anulacion = item.IdCbteCble_Anulacion;
                    dat_.IdTipoCbte_Anulacion = item.IdTipoCbte_Anulacion;
                    dat_.IdTipoFlujo = item.IdTipoFlujo;
                    dat_.PosFechado = item.PosFechado;
                    dat_.IdTipoNota = item.IdTipoNota;
                    dat_.IdPersona_Girado_a = item.IdPersona_Girado_a;
                    dat_.IdSucursal = (item.IdSucursal == null) ? 0 : Convert.ToInt32(item.IdSucursal);
                    dat_.IdEstado_Cbte_Ban_cat = item.IdEstado_Cbte_Ban_cat;
                    dat_.CodTipoCbteBan = item.CodTipoCbteBan;
                    dat_.nom_Estado_Cbte_Ban = item.nom_Estado_Cbte_Ban;

                    dat_.Beneficiario = item.Beneficiario;
                    dat_.IdTipoDocumento = item.IdTipoDocumento;
                    dat_.pe_cedulaRuc = item.pe_cedulaRuc;



                    dat_.IdEstado_Preaviso_ch_cat = (eEstado_Preaviso_Cheque)Enum.Parse(typeof(eEstado_Preaviso_Cheque), string.IsNullOrEmpty(item.IdEstado_Preaviso_ch_cat) ? eEstado_Preaviso_Cheque.ES_CH_XPREAVISO_CH.ToString() : item.IdEstado_Preaviso_ch_cat);

                    

                }
             return (dat_);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        

        public List<ba_Cbte_Ban_Info> Get_List_X_NotasMasivas(List<ba_notasDebCre_masivo_Info> ListCbtMasivo, ref string MensajeError)
        {
                List<ba_Cbte_Ban_Info> lM = new List<ba_Cbte_Ban_Info>();
                EntitiesBanco b = new EntitiesBanco();
            try
            {
                foreach (var itemM in ListCbtMasivo)
                {
                    
                       var select_ = from T in b.vwba_Cbte_Ban
                                  where T.IdEmpresa == itemM.IdEmpresa_cb  && T.IdTipocbte == itemM.IdTipocbte_cb && T.IdCbteCble ==itemM.IdCbteCble_cb 
                                  select T;
                    foreach (var item in select_)
                    {
                        ba_Cbte_Ban_Info dat_ = new ba_Cbte_Ban_Info();

                        dat_.IdEmpresa = item.IdEmpresa;
                        dat_.IdCbteCble = item.IdCbteCble;
                        dat_.IdTipocbte = item.IdTipocbte;
                        dat_.Cod_Cbtecble = item.Cod_Cbtecble;
                        dat_.IdPeriodo = item.IdPeriodo;
                        dat_.IdBanco = item.IdBanco;
                        dat_.cb_Fecha = item.cb_Fecha;
                        dat_.cb_Observacion = item.cb_Observacion;
                        dat_.cb_secuencia = item.cb_secuencia;
                        dat_.cb_Valor = item.cb_Valor;
                        dat_.cb_Cheque = item.cb_Cheque;
                        dat_.cb_ChequeImpreso = item.cb_ChequeImpreso;
                        dat_.cb_FechaCheque = item.cb_FechaCheque;
                        dat_.FechaAnulacion = item.FechaAnulacion;
                        dat_.ip = item.ip;
                        dat_.nom_pc = item.nom_pc;
                        dat_.cb_giradoA = item.cb_giradoA;
                        dat_.IdUsuario = item.IdUsuario;
                        dat_.IdUsuario_Anu = item.IdUsuario_Anu;
                        dat_.Fecha_Transac = item.Fecha_Transac;
                        dat_.Fecha_UltMod = item.Fecha_UltMod;
                        dat_.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        dat_.Estado = item.Estado;
                        dat_.MotivoAnulacion = item.MotivoAnulacion;
                        dat_.cb_ciudadChq = item.cb_ciudadChq;
                        dat_.Tipo = item.tc_TipoCbte;
                        dat_.Banco = item.ba_descripcion;

                        dat_.IdProveedor = item.IdProveedor;
                        dat_.IdCbteCble_Anulacion = item.IdCbteCble_Anulacion;
                        dat_.IdTipoCbte_Anulacion = item.IdTipoCbte_Anulacion;
                        dat_.IdTipoFlujo = item.IdTipoFlujo;
                        dat_.IdTipoNota = item.IdTipoNota;
                        dat_.IdEstado_Cbte_Ban_cat = item.IdEstado_Cbte_Ban_cat;
                        dat_.CodTipoCbteBan = item.CodTipoCbteBan;
                        dat_.nom_Estado_Cbte_Ban = item.nom_Estado_Cbte_Ban;

                        dat_.IdEstado_Preaviso_ch_cat = (eEstado_Preaviso_Cheque)Enum.Parse(typeof(eEstado_Preaviso_Cheque), string.IsNullOrEmpty(item.IdEstado_Preaviso_ch_cat) ? eEstado_Preaviso_Cheque.ES_CH_XPREAVISO_CH.ToString() : item.IdEstado_Preaviso_ch_cat);

                       lM.Add(dat_);
                    }
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<cxc_cobro_Info> Get_List_CobrosDepositados(int IdEmpresa, decimal IdCbteCble, int IdTipoCbte, ref string MensajeError)
        {
            try
            {
                List<cxc_cobro_Info> lM = new List<cxc_cobro_Info>();
                EntitiesBanco b = new EntitiesBanco();
                var select_ = from T in b.vwba_MoviCaja_Depositados
                              where T.IdEmpresa_MoviBan == IdEmpresa && T.IdTipocbte_MoviBan == IdTipoCbte && T.IdCbteCble_MoviBan == IdCbteCble
                              select T;

                foreach (var item in select_)
                {
                    cxc_cobro_Info dat = new cxc_cobro_Info();
                    dat.IdEmpresa = Convert.ToInt32((item.IdEmpresa == null) ? 0 : item.IdEmpresa);
                    dat.IdSucursal = Convert.ToInt32((item.IdSucursal == null) ? 0 : item.IdSucursal);
                    dat.IdCobro = Convert.ToDecimal((item.IdCobro == null) ? 0 : item.IdCobro); 
                    dat.IdCobro_tipo = item.IdCobro_tipo;
                    dat.IdCliente = Convert.ToDecimal((item.IdCliente == null) ? 0 : item.IdCliente);
                    dat.cr_TotalCobro = Convert.ToDouble((item.cr_TotalCobro == null) ? 0 : item.cr_TotalCobro);
                    dat.cr_fecha = Convert.ToDateTime((item.cr_fecha == null) ? DateTime.Now  : item.cr_fecha);
                    dat.cr_fechaCobro = Convert.ToDateTime((item.cr_fechaCobro==null)?DateTime.Now:item.cr_fechaCobro); 
                    dat.cr_observacion = item.cr_observacion;
                    dat.cr_Banco = item.cr_Banco;
                    dat.cr_cuenta = item.cr_cuenta;
                    dat.cr_NumDocumento = item.cr_NumDocumento;
                    dat.cr_estado = item.cr_estado;
                    dat.cr_recibo = item.cr_recibo;
                    dat.nSucursal = item.nSucursal;
                    dat.nCliente = item.nCliente;
                    dat.Caja = item.ca_Descripcion;
                    dat.IdCbteCble_MoviCaja = item.IdCbteCble_MoviCaja;
                    dat.IdTipocbte_MoviCaja = item.IdTipocbte_MoviCaja;
                    dat.Tipo = (item.tm_Signo == "-") ? "Egreso" : "Ingreso";
                    dat.Secuencia_MoviCaja = item.mcj_Secuencia;



                    dat.chek = true;
                    lM.Add(dat);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        

        public List<ba_Cbte_Ban_Info> Get_List_Cbte_Ban(int IdEmpresa, DateTime FechaInicio, DateTime FechaFin, ref string MensajeError)
        {
            try
            {
                List<ba_Cbte_Ban_Info> lista = new List<ba_Cbte_Ban_Info>();


                using (EntitiesBanco Entity = new EntitiesBanco())
                {


                    var Consulta = from q in Entity.ba_Cbte_Ban
                                   where q.cb_Fecha >= FechaInicio && q.cb_Fecha <= FechaFin
                                   && q.IdEmpresa == IdEmpresa
                                   select q;


                    foreach (var q in Consulta)
                    {
                        ba_Cbte_Ban_Info info = new ba_Cbte_Ban_Info();

                        info.IdBanco = q.IdBanco;
                        info.IdEmpresa = q.IdEmpresa;
                        info.cb_Cheque = q.cb_Cheque;
                        info.cb_ChequeImpreso = q.cb_ChequeImpreso;
                        info.cb_ciudadChq = q.cb_ciudadChq;
                        info.cb_Fecha = q.cb_Fecha;
                        info.cb_giradoA = q.cb_giradoA;
                        info.cb_FechaCheque = q.cb_FechaCheque;
                        info.cb_Observacion = q.cb_Observacion;
                        info.cb_secuencia = q.cb_secuencia;
                        info.cb_Valor = q.cb_Valor;
                        info.Cod_Cbtecble = q.Cod_Cbtecble;
                        info.Estado = q.Estado;
                        info.IdCbteCble = q.IdCbteCble;
                        info.IdCbteCble_Anulacion = q.IdCbteCble_Anulacion;
                        info.IdPeriodo = q.IdPeriodo;
                        info.IdTipocbte = q.IdTipocbte;
                        info.IdTipoFlujo = q.IdTipoFlujo;
                        info.IdProveedor = q.IdProveedor;
                        info.IdTipoCbte_Anulacion = q.IdTipoCbte_Anulacion;
                        info.IdTransaccion = q.IdTransaccion;
                        info.IdTipoNota = Convert.ToInt32(q.IdTipoNota);
                        info.IdEstado_Cbte_Ban_cat = q.IdEstado_Cbte_Ban_cat;
                        info.IdEstado_Preaviso_ch_cat = (eEstado_Preaviso_Cheque)Enum.Parse(typeof(eEstado_Preaviso_Cheque), string.IsNullOrEmpty(q.IdEstado_Preaviso_ch_cat) ? eEstado_Preaviso_Cheque.ES_CH_XPREAVISO_CH.ToString() : q.IdEstado_Preaviso_ch_cat);


                        lista.Add(info);




                    }


                    return lista;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<ba_Cbte_Ban_Info> Get_List_Cbte_Ban(int IdEmpresa, int idSucursalIni, int idSucursalFin, DateTime FechaIni, DateTime FechaFin, string idCbte_Tipo, int idBancoIni, int idBancoFin, string idCbte_ban_Estado, ref string MensajeError)
        {
            try
            {
                List<ba_Cbte_Ban_Info> lista = new List<ba_Cbte_Ban_Info>();


                using (EntitiesBanco Entity = new EntitiesBanco())
                {
                    var Consulta = from q in Entity.vwba_Cbte_Ban
                                   where q.cb_Fecha >= FechaIni && q.cb_Fecha <= FechaFin
                                   && IdEmpresa == q.IdEmpresa && idSucursalIni <= q.IdSucursal && q.IdSucursal <= idSucursalFin
                                   && q.IdEstado_Cbte_Ban_cat.Contains(idCbte_ban_Estado)
                                   && q.CodTipoCbteBan.Contains(idCbte_Tipo)
                                   && idBancoIni <= q.IdBanco && q.IdBanco <= idBancoFin
                                   select q;

                    foreach (var q in Consulta)
                    {
                        ba_Cbte_Ban_Info info = new ba_Cbte_Ban_Info();

                        info.IdBanco = q.IdBanco;
                        info.IdEmpresa = q.IdEmpresa;
                        info.cb_Cheque = q.cb_Cheque;
                        info.cb_ChequeImpreso = q.cb_ChequeImpreso;
                        info.cb_ciudadChq = q.cb_ciudadChq;
                        info.cb_Fecha = q.cb_Fecha;
                        info.cb_giradoA = q.cb_giradoA;
                        info.cb_FechaCheque = q.cb_FechaCheque;
                        info.cb_Observacion = q.cb_Observacion;
                        info.cb_secuencia = q.cb_secuencia;
                        info.cb_Valor = q.cb_Valor;
                        info.Cod_Cbtecble = q.Cod_Cbtecble;
                        info.Estado = q.Estado;
                        info.IdCbteCble = q.IdCbteCble;
                        info.IdCbteCble_Anulacion = q.IdCbteCble_Anulacion;
                        info.IdPeriodo = q.IdPeriodo;
                        info.IdTipocbte = q.IdTipocbte;
                        info.IdTipoFlujo = q.IdTipoFlujo;
                        info.IdProveedor = q.IdProveedor;
                        info.IdTipoCbte_Anulacion = q.IdTipoCbte_Anulacion;
                        info.IdTipoNota = Convert.ToInt32(q.IdTipoNota);
                        info.IdEstado_Cbte_Ban_cat = q.IdEstado_Cbte_Ban_cat;
                        
                        info.Beneficiario = q.Beneficiario;
                        info.IdTipoDocumento = q.IdTipoDocumento;
                        info.pe_cedulaRuc = q.pe_cedulaRuc;

                        info.IdEstado_Preaviso_ch_cat = (eEstado_Preaviso_Cheque)Enum.Parse(typeof(eEstado_Preaviso_Cheque), string.IsNullOrEmpty(q.IdEstado_Preaviso_ch_cat) ? eEstado_Preaviso_Cheque.ES_CH_XPREAVISO_CH.ToString() : q.IdEstado_Preaviso_ch_cat);

                        lista.Add(info);
                    }



                    return lista;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<ba_Cbte_Ban_Info> Get_List_Cbte_Ban(int IdEmpres, int IdTipocbteIni, int IdTipocbteFin, DateTime F_inicio, DateTime F_fin, ref string MensajeError)
        {
            F_inicio = F_inicio.Date;
            F_fin = F_fin.Date; 

            List<ba_Cbte_Ban_Info> lM = new List<ba_Cbte_Ban_Info>();
            EntitiesBanco b = new EntitiesBanco();
            try
            {
                var select_ = from T in b.vwba_Cbte_Ban
                              where T.IdEmpresa == IdEmpres 
                              && T.IdTipocbte >= IdTipocbteIni
                              && T.IdTipocbte <= IdTipocbteFin
                              && T.cb_Fecha >= F_inicio && T.cb_Fecha <= F_fin
                              orderby T.IdCbteCble descending
                              select T;
                foreach (var item in select_)
                {
                    ba_Cbte_Ban_Info dat_ = new ba_Cbte_Ban_Info();
                    dat_.IdEmpresa = item.IdEmpresa;
                    dat_.IdCbteCble = item.IdCbteCble;
                    dat_.IdTipocbte = item.IdTipocbte;
                    dat_.Cod_Cbtecble = item.Cod_Cbtecble;
                    dat_.IdPeriodo = item.IdPeriodo;
                    dat_.IdBanco = item.IdBanco;
                    dat_.cb_Fecha = item.cb_Fecha;
                    dat_.cb_Observacion = item.cb_Observacion;
                    dat_.cb_secuencia = item.cb_secuencia;
                    dat_.cb_Valor = item.cb_Valor;
                    dat_.cb_Cheque = item.cb_Cheque;
                    dat_.cb_ChequeImpreso = item.cb_ChequeImpreso;
                    dat_.cb_FechaCheque = item.cb_FechaCheque;
                    dat_.FechaAnulacion = item.FechaAnulacion;
                    dat_.ip = item.ip;
                    dat_.nom_pc = item.nom_pc;
                    dat_.cb_giradoA = item.cb_giradoA;
                    dat_.IdUsuario = item.IdUsuario;
                    dat_.IdUsuario_Anu = item.IdUsuario_Anu;
                    dat_.Fecha_Transac = item.Fecha_Transac;
                    dat_.Fecha_UltMod = item.Fecha_UltMod;
                    dat_.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    dat_.Estado = item.Estado;
                    dat_.MotivoAnulacion = item.MotivoAnulacion;
                    dat_.cb_ciudadChq = item.cb_ciudadChq;
                    dat_.Tipo = item.tc_TipoCbte;
                    dat_.Banco = item.ba_descripcion;

                    dat_.IdProveedor = item.IdProveedor;
                    dat_.IdCbteCble_Anulacion = item.IdCbteCble_Anulacion;
                    dat_.IdTipoCbte_Anulacion = item.IdTipoCbte_Anulacion;
                    dat_.IdTipoFlujo = item.IdTipoFlujo;
                    dat_.PosFechado = item.PosFechado;
                    dat_.IdTipoNota = item.IdTipoNota;
                    dat_.IdSucursal = (item.IdSucursal == null) ? 0 : Convert.ToInt32(item.IdSucursal);
                    dat_.IdPersona_Girado_a = item.IdPersona_Girado_a;
                    dat_.IdEstado_Cbte_Ban_cat = item.IdEstado_Cbte_Ban_cat;
                    dat_.CodTipoCbteBan = item.CodTipoCbteBan;
                    dat_.nom_Estado_Cbte_Ban = item.nom_Estado_Cbte_Ban;

                    dat_.Beneficiario = item.Beneficiario;
                    dat_.IdTipoDocumento = item.IdTipoDocumento;
                    dat_.pe_cedulaRuc = item.pe_cedulaRuc;
                    dat_.IdEstado_cheque_cat = (eEstado_Cheque)Enum.Parse(typeof(eEstado_Cheque), string.IsNullOrEmpty(item.IdEstado_cheque_cat) ? eEstado_Cheque.ESTCBEMI.ToString() : item.IdEstado_cheque_cat);
                    dat_.IdEstado_Preaviso_ch_cat = (eEstado_Preaviso_Cheque)Enum.Parse(typeof(eEstado_Preaviso_Cheque), string.IsNullOrEmpty(item.IdEstado_Preaviso_ch_cat) ? eEstado_Preaviso_Cheque.ES_CH_XPREAVISO_CH.ToString() : item.IdEstado_Preaviso_ch_cat);
                    dat_.Beneficiario = item.Beneficiario;
                    lM.Add(dat_);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<ba_Cbte_Ban_Info> Get_List_Cbte_Ban(int IdEmpres,  int IdTipocbteBan, DateTime F_inicio, DateTime F_fin, 
            string IdEstado_Preaviso_ch_cat, ref string MensajeError)
        {

            F_inicio = Convert.ToDateTime(F_inicio.ToShortDateString());
            F_fin = Convert.ToDateTime(F_fin.ToShortDateString());


            List<ba_Cbte_Ban_Info> lM = new List<ba_Cbte_Ban_Info>();
            EntitiesBanco b = new EntitiesBanco();
            try
            {
                var select_ = from T in b.vwba_Cbte_Ban
                              where T.IdEmpresa == IdEmpres
                              && T.IdTipocbte == IdTipocbteBan
                              && T.cb_Fecha >= F_inicio && T.cb_Fecha <= F_fin
                              && T.IdEstado_Preaviso_ch_cat.Contains(IdEstado_Preaviso_ch_cat)
                              && T.Estado == "A"
                              orderby T.IdCbteCble descending
                              select T;
                foreach (var item in select_)
                {
                    ba_Cbte_Ban_Info dat_ = new ba_Cbte_Ban_Info();
                    dat_.IdEmpresa = item.IdEmpresa;
                    dat_.IdCbteCble = item.IdCbteCble;
                    dat_.IdTipocbte = item.IdTipocbte;
                    dat_.Cod_Cbtecble = item.Cod_Cbtecble;
                    dat_.IdPeriodo = item.IdPeriodo;
                    dat_.IdBanco = item.IdBanco;
                    dat_.cb_Fecha = item.cb_Fecha;
                    dat_.cb_Observacion = item.cb_Observacion;
                    dat_.cb_secuencia = item.cb_secuencia;
                    dat_.cb_Valor = item.cb_Valor;
                    dat_.cb_Cheque = item.cb_Cheque;
                    dat_.cb_ChequeImpreso = item.cb_ChequeImpreso;
                    dat_.cb_FechaCheque = item.cb_FechaCheque;
                    dat_.FechaAnulacion = item.FechaAnulacion;
                    dat_.ip = item.ip;
                    dat_.nom_pc = item.nom_pc;
                    dat_.cb_giradoA = item.cb_giradoA;
                    dat_.IdUsuario = item.IdUsuario;
                    dat_.IdUsuario_Anu = item.IdUsuario_Anu;
                    dat_.Fecha_Transac = item.Fecha_Transac;
                    dat_.Fecha_UltMod = item.Fecha_UltMod;
                    dat_.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    dat_.Estado = item.Estado;
                    dat_.MotivoAnulacion = item.MotivoAnulacion;
                    dat_.cb_ciudadChq = item.cb_ciudadChq;
                    dat_.Tipo = item.tc_TipoCbte;
                    dat_.Banco = item.ba_descripcion;

                    dat_.IdProveedor = item.IdProveedor;
                    dat_.IdCbteCble_Anulacion = item.IdCbteCble_Anulacion;
                    dat_.IdTipoCbte_Anulacion = item.IdTipoCbte_Anulacion;
                    dat_.IdTipoFlujo = item.IdTipoFlujo;
                    dat_.PosFechado = item.PosFechado;
                    dat_.IdTipoNota = item.IdTipoNota;
                    dat_.IdSucursal = (item.IdSucursal == null) ? 0 : Convert.ToInt32(item.IdSucursal);
                    dat_.IdPersona_Girado_a = item.IdPersona_Girado_a;
                    dat_.IdEstado_Cbte_Ban_cat = item.IdEstado_Cbte_Ban_cat;
                    dat_.CodTipoCbteBan = item.CodTipoCbteBan;
                    dat_.nom_Estado_Cbte_Ban = item.nom_Estado_Cbte_Ban;


                    dat_.Beneficiario = item.Beneficiario;
                    dat_.IdTipoDocumento = item.IdTipoDocumento;
                    dat_.pe_cedulaRuc = item.pe_cedulaRuc;


                    dat_.IdEstado_Preaviso_ch_cat = (eEstado_Preaviso_Cheque)Enum.Parse(typeof(eEstado_Preaviso_Cheque), string.IsNullOrEmpty(item.IdEstado_Preaviso_ch_cat) ? eEstado_Preaviso_Cheque.ES_CH_XPREAVISO_CH.ToString() : item.IdEstado_Preaviso_ch_cat);




                    lM.Add(dat_);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public decimal getSecuencia(ref string MensajeError)
        {
            try
            {
                decimal secuencia;
                EntitiesBanco base_ = new EntitiesBanco();

                var q = from C in base_.ba_Cbte_Ban
                        select C;

                if (q.ToList().Count <1)
                    return 1;
                else
                {
                    base_ = new EntitiesBanco();
                    var select_ = (from T in base_.ba_Cbte_Ban
                                   select T.cb_secuencia).Max();
                    secuencia = Convert.ToInt32(select_.ToString()) + 1;
                    return secuencia;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                //return -1;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GrabarDB(ba_Cbte_Ban_Info info, ref string MensajeError)
        {
            try
            {
                // int idBanco;
                try
                {


                    using (EntitiesBanco context = new EntitiesBanco())
                    {
                        EntitiesBanco EDB = new EntitiesBanco();
                        ba_Cbte_Ban address = new ba_Cbte_Ban();
                        address.IdEmpresa = info.IdEmpresa;
                        address.IdCbteCble = info.IdCbteCble;
                        address.IdTipocbte = info.IdTipocbte;
                        address.Cod_Cbtecble = string.IsNullOrEmpty(info.Cod_Cbtecble) ? "" : info.Cod_Cbtecble;
                        address.IdPeriodo = info.IdPeriodo;
                        address.IdBanco = info.IdBanco;
                        address.cb_Fecha = info.cb_Fecha;
                        address.cb_Observacion = info.cb_Observacion;
                        address.cb_secuencia = getSecuencia(ref MensajeError);
                        address.cb_Valor = info.cb_Valor;
                        address.cb_Cheque = info.cb_Cheque;
                        address.cb_ChequeImpreso = (info.cb_ChequeImpreso == null) ? "N" : info.cb_ChequeImpreso;
                        address.cb_FechaCheque = info.cb_FechaCheque;
                        address.cb_ciudadChq = (info.cb_ciudadChq == "") ? null : info.cb_ciudadChq;
                        address.cb_giradoA = info.cb_giradoA;
                        address.PosFechado = info.PosFechado;
                        address.IdTipoNota = info.IdTipoNota;
                        address.Estado = "A";
                        address.IdUsuario = info.IdUsuario;
                        address.Fecha_Transac = info.Fecha_Transac;
                        address.nom_pc = info.nom_pc;
                        address.ip = info.ip;
                        address.IdProveedor = info.IdProveedor;
                        address.IdTipoFlujo = info.IdTipoFlujo;
                        address.IdTransaccion = info.IdTransaccion;
                        address.IdPersona_Girado_a = info.IdPersona_Girado_a;
                        address.ValorEnLetras = info.ValorEnLetras;
                        address.IdSucursal = info.IdSucursal;
                        address.IdEstado_Cbte_Ban_cat = info.IdEstado_Cbte_Ban_cat;
                        address.IdEstado_Preaviso_ch_cat = eEstado_Preaviso_Cheque.ES_CH_XPREAVISO_CH.ToString();
                        address.IdEstado_cheque_cat = "ESTCBEMI";

                        context.ba_Cbte_Ban.Add(address);
                        context.SaveChanges();
                    }
                    return true;
                }
                catch (DbEntityValidationException ex)
                {
                    string mensaje = "";
                    string arreglo = ToString();
                    foreach (var item in ex.EntityValidationErrors)
                    {
                        foreach (var item_validaciones in item.ValidationErrors)
                        {
                            mensaje = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                        }
                    }
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    throw new Exception(mensaje);
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                Console.WriteLine(ex.InnerException.Message);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ActualizarUltimocheque(ba_Cbte_Ban_Info info, ref string MensajeError)
        {
            try
            {
             Boolean result = false;
                        try
                        {
                            using (EntitiesBanco context = new EntitiesBanco())
                            {
                                if (info.cb_Cheque != null)
                                {
                                    var contactNCh = context.ba_Banco_Cuenta.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdBanco == info.IdBanco);
                                    if (contactNCh != null)
                                    {
                                        contactNCh.ba_Ultimo_Cheque = info.cb_Cheque;
                                        contactNCh.Fecha_UltMod = info.Fecha_UltMod;
                                        contactNCh.IdUsuarioUltMod = info.IdUsuarioUltMod;
                                        context.SaveChanges();
                                    }
                                }
                            } result = true;
                        }
                        catch (Exception ex)
                        {
                            string arreglo = ToString();
                            tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                            tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                                "", "", "", "", DateTime.Now);
                            oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                            MensajeError = ex.ToString() + " " + ex.Message;
                            throw new Exception(ex.ToString());
                        }
                    return result;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
        
        public Boolean ActualizarObservacion(ba_Cbte_Ban_Info info, ref string MensajeError)
        {
            try
            {
                Boolean result = false;
                try
                {
                    using (EntitiesBanco context = new EntitiesBanco())
                    {
                        if (info.cb_Cheque != null)
                        {
                            var contactNCh = context.ba_Cbte_Ban.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdCbteCble == info.IdCbteCble && minfo.IdTipocbte==info.IdTipocbte);
                            if (contactNCh != null)
                            {
                                contactNCh.cb_Observacion = info.cb_Observacion;
                               context.SaveChanges();
                            }
                        }
                    } result = true;
                }
                catch (Exception ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                        "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                    MensajeError = ex.ToString() + " " + ex.Message;
                    throw new Exception(ex.ToString());
                }
                return result;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean AnularDB(ba_Cbte_Ban_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    var contact = context.ba_Cbte_Ban.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdCbteCble == info.IdCbteCble && minfo.IdTipocbte == info.IdTipocbte);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.FechaAnulacion = info.FechaAnulacion;
                        contact.IdUsuario_Anu = info.IdUsuario_Anu;
                        contact.MotivoAnulacion = info.MotivoAnulacion;
                        contact.IdCbteCble_Anulacion = info.IdCbteCble_Anulacion;
                        contact.IdTipoCbte_Anulacion = info.IdTipoCbte_Anulacion;
                        contact.cb_Observacion = "**ANULADO** " + contact.cb_Observacion;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(ba_Cbte_Ban_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    var contact = context.ba_Cbte_Ban.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdCbteCble == info.IdCbteCble && minfo.IdTipocbte == info.IdTipocbte);
                    if (contact != null)
                    {
                        contact.Cod_Cbtecble = info.Cod_Cbtecble;
                        contact.cb_Fecha = info.cb_Fecha;
                        contact.cb_Observacion = info.cb_Observacion;
                        contact.cb_secuencia = info.cb_secuencia;
                        contact.cb_Valor = info.cb_Valor;
                        contact.cb_Cheque = info.cb_Cheque;
                        contact.cb_ChequeImpreso = info.cb_ChequeImpreso;
                        contact.cb_ciudadChq = (info.cb_ciudadChq == "") ? null : info.cb_ciudadChq;
                        contact.IdProveedor = info.IdProveedor;
                        contact.IdTipoFlujo = info.IdTipoFlujo;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean VericarChequeExiste(string cheque, int IdEmp,decimal IdCbteCble,int IdTipoCbte,int IdBanco, ref string mensaje)
        {
            try
            {
                Boolean Existe;
                string NCheque;
                NCheque = cheque.Trim();
                mensaje = "";
                Existe = false;

                EntitiesBanco B = new EntitiesBanco();

                var select_ = from t in B.ba_Cbte_Ban
                              where t.IdEmpresa == IdEmp &&
                                    t.IdBanco == IdBanco &&
                                    t.IdTipocbte == IdTipoCbte &&
                                    t.cb_Cheque != "0"
                              select t;
                int c = 0;
                foreach (var item in select_)
                {
                    if (item.cb_Cheque != null && item.cb_Cheque.Trim() !="" )
                    {
                        
                        if (Convert.ToDecimal(item.cb_Cheque) == Convert.ToDecimal(NCheque))
                        {
                            c++;
                            mensaje = mensaje + " " + item.cb_giradoA + " Con el Comprobante # " + item.IdCbteCble.ToString();
                        }
                    }
                }
                if(c>0)
                    Existe = true;
                else
                    Existe = false;
                return Existe;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
       }

        public Boolean Modificar_Estado_cbte_ban(List<ba_Cbte_Ban_Info> Lista, ref string MensajeError)
        {
            try
            {
                foreach (var item in Lista)
                {
                    using (EntitiesBanco Conexion = new EntitiesBanco())
                    {
                        ba_Cbte_Ban Entity = Conexion.ba_Cbte_Ban.FirstOrDefault(q =>q.IdEmpresa == item.IdEmpresa && q.IdBanco == item.IdBanco && q.IdCbteCble == item.IdCbteCble);
                        if (Entity!=null)
                        {
                            Entity.IdEstado_Cbte_Ban_cat = item.IdEstado_Cbte_Ban_cat;
                            Conexion.SaveChanges(); 
                        }
                        
                    }
                }
            return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public Boolean Modificar_Estado_Preaviso_ch(List<ba_Cbte_Ban_Info> Lista,eEstado_Preaviso_Cheque IdEstado_Preaviso, ref string MensajeError)
        {
            try
            {
                foreach (var item in Lista)
                {
                    using (EntitiesBanco Conexion = new EntitiesBanco())
                    {
                        ba_Cbte_Ban Entity = Conexion.ba_Cbte_Ban.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa 
                            && q.IdTipocbte == item.IdTipocbte
                            && q.IdCbteCble == item.IdCbteCble);

                        if (Entity != null)
                        {
                            Entity.IdEstado_Preaviso_ch_cat = IdEstado_Preaviso.ToString();
                            Conexion.SaveChanges();
                        }

                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean VerificarExisteRegistroImportacion(string IdHash, ref string MensajeError)
        {
            try
            {
                using(EntitiesBanco entity = new EntitiesBanco())
	            {
                    var Cant = (from q in entity.ba_Cbte_Ban where q.IdTransaccion == IdHash select q).Count();
                    if(Cant!=0)
                        return true;
                    else
                        return false;
	            }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<vwba_Banco_Movimiento_det_cancelado_Info> Get_List_Cancelada(int IdEmpresa, decimal IdCbteCble, int IdTipocbte, ref string MensajeError)
        {
            try
            {
                 List<vwba_Banco_Movimiento_det_cancelado_Info> Listado = new List<vwba_Banco_Movimiento_det_cancelado_Info>();
                    try
                    {
                        EntitiesBanco db = new EntitiesBanco();

                        db.SetCommandTimeOut(3000);

                        var select_ = from T in db.vwba_Banco_Movimiento_det_cancelado
                                      where T.IdEmpresa == IdEmpresa && T.IdCbteCble == IdCbteCble && T.IdTipocbte == IdTipocbte
                                      select T;

                        foreach (var item in select_)
                        {
                            vwba_Banco_Movimiento_det_cancelado_Info dat = new vwba_Banco_Movimiento_det_cancelado_Info();
                            dat.SaldoAnterior = item.SaldoAnterior;
                            dat.SaldoActual = item.SaldoActual;
                            dat.IdEmpresa = item.IdEmpresa;
                            dat.IdCbteCble = item.IdCbteCble;
                            dat.IdTipocbte = item.IdTipocbte;
                            dat.IdEmpresaBanco = item.IdEmpresaBanco;
                            dat.IdTipo_op = item.IdTipo_op;
                            dat.Referencia = item.Referencia;
                            dat.IdOrdenPago = item.IdOrdenPago;
                            dat.Secuencia_OP = item.Secuencia_OP;
                            dat.IdTipoPersona = item.IdTipoPersona;
                            dat.IdPersona = item.IdPersona;
                            dat.IdEntidad = item.IdEntidad;
                            dat.Fecha_OP = item.Fecha_OP;
                            dat.Fecha_Fa_Prov = item.Fecha_Fa_Prov;
                            dat.Fecha_Venc_Fac_Prov = item.Fecha_Venc_Fac_Prov;
                            dat.Observacion = item.Observacion;
                            dat.Nom_Beneficiario = item.Nom_Beneficiario;
                            dat.Girar_Cheque_a = item.Girar_Cheque_a;
                            dat.Valor_a_pagar = item.Valor_a_pagar;
                            dat.Valor_estimado_a_pagar_OP = item.Valor_estimado_a_pagar_OP;
                            dat.Total_cancelado_OP = item.Total_cancelado_OP;
                            dat.Saldo_x_Pagar_OP = item.Saldo_x_Pagar_OP;
                            dat.IdEstadoAprobacion = item.IdEstadoAprobacion;
                            dat.IdFormaPago = item.IdFormaPago;
                            dat.Fecha_Pago = item.Fecha_Pago;
                            dat.IdCtaCble = item.IdCtaCble;
                            dat.IdCentroCosto = item.IdCentroCosto;
                            dat.IdSubCentro_Costo = item.IdSubCentro_Costo;
                            dat.Cbte_cxp = item.Cbte_cxp;
                            dat.Estado = item.Estado;
                            dat.Nom_Beneficiario_2 = item.Nom_Beneficiario_2;
                            dat.Valor_aplicado = item.MontoAplicado;
                            dat.PosFechado = item.PosFechado;
                            dat.Idcancelacion = item.Idcancelacion;
                            dat.IdEmpresa_cxp = item.IdEmpresa_cxp;
                            dat.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                            dat.IdCbteCble_cxp = item.IdCbteCble_cxp;
                            dat.Secuencia = item.Secuencia;
                            Listado.Add(dat);
                        }
                    }
                    catch (Exception ex)
                    {
                        string arreglo = ToString();
                        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                            "", "", "", "", DateTime.Now);
                        oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                        MensajeError = ex.InnerException + " " + ex.Message;
                        throw new Exception(ex.InnerException.ToString());
                    }
                    return Listado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<vwcp_orden_pago_con_cancelacion_x_CbteBan_Debi_Info> Get_List_CanceladaNotaDebCred(int IdEmpresa, decimal IdCbteCble, int IdTipocbte, ref string MensajeError)
        {
            try
            {
                 List<vwcp_orden_pago_con_cancelacion_x_CbteBan_Debi_Info> Listado = new List<vwcp_orden_pago_con_cancelacion_x_CbteBan_Debi_Info>();
                    try
                    {
                        EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();

                        var select_ = from T in db.vwcp_orden_pago_con_cancelacion_x_CbteBan_Debi
                                      where T.IdEmpresa == IdEmpresa && T.IdCbteCble_pago == IdCbteCble && T.IdTipoCbte_pago == IdTipocbte
                                      select T;

                        foreach (var item in select_)
                        {
                            vwcp_orden_pago_con_cancelacion_x_CbteBan_Debi_Info dat = new vwcp_orden_pago_con_cancelacion_x_CbteBan_Debi_Info();
                            dat.SaldoAnterior = item.SaldoAnterior;
                            dat.SaldoActual = item.SaldoActual;
                            dat.IdEmpresa = item.IdEmpresa;
                            dat.IdTipo_op = item.IdTipo_op;
                            dat.Referencia = item.Referencia;
                            dat.IdOrdenPago = Convert.ToDecimal(item.IdOrdenPago);
                            dat.Secuencia_OP = Convert.ToInt32(item.Secuencia_OP);
                            dat.IdTipoPersona = item.IdTipoPersona;
                            dat.IdPersona = item.IdPersona;
                            dat.IdEntidad = item.IdEntidad;
                            dat.Fecha_OP = item.Fecha_OP;
                            dat.Fecha_Fa_Prov = item.Fecha_Fa_Prov;
                            dat.Fecha_Venc_Fac_Prov = item.Fecha_Venc_Fac_Prov;
                            dat.Observacion = item.Observacion;
                            dat.Nom_Beneficiario = item.Nom_Beneficiario;
                            dat.Girar_Cheque_a = item.Girar_Cheque_a;
                            dat.Valor_a_pagar = item.Valor_a_pagar;
                            dat.Valor_estimado_a_pagar_OP = item.Valor_estimado_a_pagar_OP;
                            dat.Total_cancelado_OP = item.Total_cancelado_OP;
                            dat.Saldo_x_Pagar_OP = item.Saldo_x_Pagar_OP;
                            dat.IdEstadoAprobacion = item.IdEstadoAprobacion;
                            dat.IdFormaPago = item.IdFormaPago;
                            dat.Fecha_Pago = Convert.ToDateTime(item.Fecha_Pago);
                            dat.IdCtaCble = item.IdCtaCble;
                            dat.IdCentroCosto = item.IdCentroCosto;
                            dat.IdSubCentro_Costo = item.IdSubCentro_Costo;
                            dat.Cbte_cxp = item.Cbte_cxp;
                            dat.Estado = item.Estado;
                            dat.Nom_Beneficiario_2 = item.Nom_Beneficiario_2;
                            dat.Valor_aplicado = item.MontoAplicado;
                            dat.Idcancelacion = item.Idcancelacion;
                            dat.IdEmpresa_pago = item.IdEmpresa_pago;
                            dat.IdTipoCbte_pago = item.IdTipoCbte_pago;
                            dat.IdCbteCble_pago = item.IdCbteCble_pago;
                            Listado.Add(dat);
                        }
                    }
                    catch (Exception ex)
                    {
                        string arreglo = ToString();
                        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                            "", "", "", "", DateTime.Now);
                        oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                        MensajeError = ex.InnerException + " " + ex.Message;
                        throw new Exception(ex.InnerException.ToString());
                    }
                    return Listado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public Boolean Modificar_estado_Cheq(ba_Cbte_Ban_Info info, eEstado_Cheque Estado, ref string MensajeError)
        {
            try
            {
                using (EntitiesBanco context = new EntitiesBanco())
                {
                    var contact = context.ba_Cbte_Ban.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa 
                        && minfo.IdCbteCble == info.IdCbteCble && minfo.IdTipocbte == info.IdTipocbte);
                    if (contact != null)
                    {
                        contact.IdEstado_cheque_cat = Estado.ToString();
                        
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Modificar_tipo_flujo(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble, Nullable<decimal> IdTipoFlujo)
        {
            try
            {
                using (EntitiesBanco Context = new EntitiesBanco())
                {
                    ba_Cbte_Ban Entity = Context.ba_Cbte_Ban.FirstOrDefault(q => q.IdEmpresa == IdEmpresa && q.IdTipocbte == IdTipoCbte && q.IdCbteCble == IdCbteCble);
                    if (Entity != null)
                    {
                        Entity.IdTipoFlujo = IdTipoFlujo;
                        Context.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

    }
}
