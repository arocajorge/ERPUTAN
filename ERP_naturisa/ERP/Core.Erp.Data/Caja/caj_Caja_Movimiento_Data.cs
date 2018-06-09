using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Caja;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Caja
{ 
    
    public class caj_Caja_Movimiento_Data
    {
  


        public List<caj_Caja_Movimiento_Info> Get_list_Ingreso(int IdEmpresa,DateTime FechaIni,DateTime FechaFin, ref string MensajeError)
        {
                List<caj_Caja_Movimiento_Info> lM = new List<caj_Caja_Movimiento_Info>();
            try
            {
                EntitiesCaja db = new EntitiesCaja();

                var select_ = from T in db.vwcaj_caj_Caja_Movimiento
                              where T.IdEmpresa == IdEmpresa
                              && T.cm_Signo == "+"
                              && T.cm_fecha >= FechaIni && T.cm_fecha <= FechaFin
                              select T;


                foreach (var item in select_)
                {
                    caj_Caja_Movimiento_Info dat = new caj_Caja_Movimiento_Info();
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdCbteCble = item.IdCbteCble;
                    dat.IdTipocbte = item.IdTipocbte;
                    dat.cm_Signo = item.cm_Signo;
                    dat.cm_beneficiario = item.cm_beneficiario;
                    dat.cm_valor = item.cm_valor;
                    dat.IdTipoMovi = item.IdTipoMovi;
                    dat.cm_observacion = item.cm_observacion;
                    dat.IdCaja = item.IdCaja;
                    dat.IdPeriodo = item.IdPeriodo;
                    dat.cm_fecha = item.cm_fecha;
                    dat.IdUsuario = item.IdUsuario;
                    dat.IdUsuario_Anu = item.IdUsuario_Anu;
                    dat.FechaAnulacion = item.FechaAnulacion;
                    dat.Fecha_Transac = item.Fecha_Transac;
                    dat.Fecha_UltMod = item.Fecha_UltMod;
                    dat.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    dat.Estado = item.Estado;
                    dat.MotivoAnulacion = item.MotivoAnulacion;
                    dat.IdUsuario_Aprueba = item.IdUsuario_Aprueba;
                    dat.IngEgr = (item.cm_Signo == "+") ? "Ingreso" : "Egreso";
                    dat.NCaja = item.ca_Descripcion;
                    dat.NTipoMovi = item.NTipoMov;
                    dat.IdCbteCble_Anu = item.IdCbteCble_Anu;
                    dat.IdTipocbte_Anu = item.IdTipocbte_Anu;
                    dat.CodMoviCaja = item.CodMoviCaja;
                    dat.ResponsableCaja = (item.ResponsableCaja != null) ? item.ResponsableCaja.Trim() : "";
                    dat.IdSucursal = item.IdSucursal;
                    dat.NSucursal = item.Su_Descripcion.Trim();
                    dat.Nom_Beneficiario = item.nom_Beneficiario;

                    dat.IdTipo_Persona = item.IdTipo_Persona;
                    dat.IdEntidad = item.IdEntidad;
                    dat.IdRecibo = item.IdRecibo;//opin 2017/03/24
                    dat.IdPuntoVta = item.IdPuntoVta;//opin 2017/03/24
                    if (item.IdTipoFlujo !=null)
                    {
                        dat.IdTipoFlujo = Convert.ToDecimal(item.IdTipoFlujo);
                    }
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
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }

        public List<caj_Caja_Movimiento_Info> Get_list_Egreso(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, ref string MensajeError)
        {
                List<caj_Caja_Movimiento_Info> lM = new List<caj_Caja_Movimiento_Info>();
            try
            {
                EntitiesCaja db = new EntitiesCaja();

                var select_ = from T in db.vwcaj_caj_Caja_Movimiento
                              where T.IdEmpresa == IdEmpresa
                              && T.cm_Signo == "-"
                               && T.cm_fecha >= FechaIni && T.cm_fecha <= FechaFin
                              select T;


                foreach (var item in select_)
                {
                    caj_Caja_Movimiento_Info dat = new caj_Caja_Movimiento_Info();
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdCbteCble = item.IdCbteCble;
                    dat.IdTipocbte = item.IdTipocbte;
                    dat.cm_Signo = item.cm_Signo;
                    dat.cm_beneficiario = item.cm_beneficiario;
                    dat.cm_valor = item.cm_valor;
                    dat.IdTipoMovi = item.IdTipoMovi;
                    dat.cm_observacion = item.cm_observacion;
                    dat.IdCaja = item.IdCaja;
                    dat.IdPeriodo = item.IdPeriodo;
                    dat.cm_fecha = item.cm_fecha;
                    dat.IdUsuario = item.IdUsuario;
                    dat.IdUsuario_Anu = item.IdUsuario_Anu;
                    dat.FechaAnulacion = item.FechaAnulacion;
                    dat.Fecha_Transac = item.Fecha_Transac;
                    dat.Fecha_UltMod = item.Fecha_UltMod;
                    dat.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    dat.Estado = item.Estado;
                    dat.MotivoAnulacion = item.MotivoAnulacion;
                    dat.IdUsuario_Aprueba = item.IdUsuario_Aprueba;
                    dat.IngEgr = (item.cm_Signo == "+") ? "Ingreso" : "Egreso";
                    dat.NCaja = item.ca_Descripcion;
                    dat.NTipoMovi = item.NTipoMov;
                    dat.IdCbteCble_Anu = item.IdCbteCble_Anu;
                    dat.IdTipocbte_Anu = item.IdTipocbte_Anu;
                    dat.CodMoviCaja = item.CodMoviCaja;
                    dat.ResponsableCaja = (item.ResponsableCaja != null) ? item.ResponsableCaja.Trim() : "";
                    dat.IdSucursal = item.IdSucursal;
                    dat.NSucursal = item.Su_Descripcion.Trim();
                    dat.Nom_Beneficiario = item.nom_Beneficiario;
                    
                    dat.IdTipo_Persona = item.IdTipo_Persona;
                    dat.IdEntidad = item.IdEntidad;
                    dat.IdRecibo = item.IdRecibo;//opin 2017/03/24
                    dat.IdPuntoVta = item.IdPuntoVta;//opin 2017/03/24
                    if (item.IdTipoFlujo != null)
                    {
                        dat.IdTipoFlujo = Convert.ToDecimal(item.IdTipoFlujo);
                    }

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
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }
     
        public Boolean GrabarDB(caj_Caja_Movimiento_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesCaja context = new EntitiesCaja())
                {
                    EntitiesCaja EDB = new EntitiesCaja();

                    caj_Caja_Movimiento address = new caj_Caja_Movimiento();

                    address.IdEmpresa = info.IdEmpresa;
                    address.IdCbteCble = info.IdCbteCble;
                    address.IdTipocbte = info.IdTipocbte;
                    address.cm_Signo = info.cm_Signo;
                    if (info.cm_beneficiario == null)
                    {
                        address.cm_beneficiario = ".";
                    }
                    else
                    {
                        address.cm_beneficiario = info.cm_beneficiario;
                    }
                    address.cm_valor = info.cm_valor;
                    address.IdTipoMovi =(int) info.IdTipoMovi;
                    if (info.cm_observacion == null)
                    {
                        address.cm_observacion = ".";
                    }
                    else
                    {
                        address.cm_observacion = info.cm_observacion;
                    }
                   
                    address.IdCaja = info.IdCaja;
                    address.IdPeriodo = info.IdPeriodo;
                    address.cm_fecha = info.cm_fecha.Date;
                    address.IdUsuario = info.IdUsuario;
                    address.Fecha_Transac = info.Fecha_Transac.Date;
                    address.Estado = "A";
                    address.IdUsuario_Aprueba = info.IdUsuario_Aprueba;
                    address.CodMoviCaja = info.CodMoviCaja;
                    address.IdSucursal = info.IdSucursal;
                    address.IdUsuario_Anu = info.IdUsuario_Anu;
                    address.FechaAnulacion = info.FechaAnulacion;
                    address.Fecha_UltMod = info.Fecha_UltMod;
                    address.IdUsuarioUltMod = info.IdUsuarioUltMod;
                    address.MotivoAnulacion = info.MotivoAnulacion;
                    address.IdCbteCble_Anu = info.IdCbteCble_Anu;
                    address.IdTipocbte_Anu = info.IdTipocbte_Anu;
                    address.IdTipoFlujo = info.IdTipoFlujo;
                    address.IdEntidad = info.IdEntidad;
                    address.IdTipo_Persona = info.IdTipo_Persona;
                    address.IdPersona = info.IdPersona;
                    //contact = address;
                    //opin 2017/03/23
                    address.IdPuntoVta = info.IdPuntoVta;
                    address.IdRecibo = info.IdRecibo;

                    context.caj_Caja_Movimiento.Add(address);
                    context.SaveChanges();
                    //grabar detalle caja movi
                    if (info.list_Caja_Movi_det.Count !=0)
                    {

                        foreach (var item in info.list_Caja_Movi_det)
                        {
                            item.IdTipocbte = info.IdTipocbte;
                            item.IdCbteCble = info.IdCbteCble;
                        }

                        caj_Caja_Movimiento_det_Data odata = new caj_Caja_Movimiento_det_Data();
                        if (!odata.GrabarDB(info.list_Caja_Movi_det, ref MensajeError))
                            return false;                   
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
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(caj_Caja_Movimiento_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesCaja context = new EntitiesCaja())
                {
                    var contact = context.caj_Caja_Movimiento.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdCbteCble == info.IdCbteCble && minfo.IdTipocbte == info.IdTipocbte);

                    if (contact != null)
                    {
                        contact.cm_valor = info.cm_valor;
                        contact.cm_observacion = info.cm_observacion;
                        contact.cm_fecha = info.cm_fecha;
                        contact.Estado = info.Estado;
                        contact.IdUsuario_Aprueba = info.IdUsuario_Aprueba;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.IdTipoFlujo = info.IdTipoFlujo;
                        contact.IdTipoMovi = Convert.ToInt32(info.IdTipoMovi);
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
                MensajeError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(caj_Caja_Movimiento_Info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesCaja context = new EntitiesCaja())
                {
                    var contact = context.caj_Caja_Movimiento.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdCbteCble == info.IdCbteCble && minfo.IdTipocbte == info.IdTipocbte);

                    if (contact != null)
                    {

                        contact.Estado = "I";
                        contact.FechaAnulacion = info.FechaAnulacion;
                        contact.IdUsuario_Anu = info.IdUsuario_Anu;
                        contact.MotivoAnulacion = info.MotivoAnulacion;
                        contact.IdCbteCble_Anu = info.IdCbteCble_Anu;
                        contact.IdTipocbte_Anu = info.IdTipocbte_Anu;
                        contact.cm_observacion = "***REVERSADO***" + info.cm_observacion;
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
                MensajeError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public caj_Caja_Movimiento_Info Get_Info_MovimientoCaja(int IdEmpresa, decimal IdCbteCble, int IdTipoCbte, ref string MensajeError)
        {
                caj_Caja_Movimiento_Info lM = new caj_Caja_Movimiento_Info();
                EntitiesCaja db = new EntitiesCaja();
            try
            {
                var select_ = from T in db.vwcaj_caj_Caja_Movimiento
                              where T.IdEmpresa == IdEmpresa && T.IdCbteCble == IdCbteCble && T.IdTipocbte == IdTipoCbte
                              select T;

                foreach (var item in select_)
                {
                    caj_Caja_Movimiento_Info dat = new caj_Caja_Movimiento_Info();
                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdCbteCble = item.IdCbteCble;
                    dat.IdTipocbte = item.IdTipocbte;
                    dat.cm_Signo = item.cm_Signo;
                    dat.cm_beneficiario = item.cm_beneficiario;
                    dat.cm_valor = item.cm_valor;
                    dat.IdTipoMovi = item.IdTipoMovi;
                    dat.cm_observacion = item.cm_observacion;
                    dat.IdCaja = item.IdCaja;
                    dat.IdPeriodo = item.IdPeriodo;
                    dat.cm_fecha = item.cm_fecha;
                    dat.IdUsuario = item.IdUsuario;
                    dat.IdUsuario_Anu = item.IdUsuario_Anu;
                    dat.FechaAnulacion = item.FechaAnulacion;
                    dat.Fecha_Transac = item.Fecha_Transac;
                    dat.Fecha_UltMod = item.Fecha_UltMod;
                    dat.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    dat.Estado = item.Estado;
                    dat.MotivoAnulacion = item.MotivoAnulacion;
                    dat.IdUsuario_Aprueba = item.IdUsuario_Aprueba;
                    dat.IngEgr = (item.cm_Signo == "+") ? "Ingreso" : "Egreso";
                    dat.NCaja = item.ca_Descripcion;
                    dat.NTipoMovi = item.NTipoMov;
                    dat.IdCbteCble_Anu = item.IdCbteCble_Anu;
                    dat.IdTipocbte_Anu = item.IdTipocbte_Anu;
                    dat.CodMoviCaja = item.CodMoviCaja;
                    dat.ResponsableCaja = item.ResponsableCaja;
                    dat.IdSucursal = item.IdSucursal;
                    dat.NSucursal = item.Su_Descripcion;

                    dat.IdTipo_Persona = item.IdTipo_Persona;
                    dat.IdEntidad = item.IdEntidad;

                    if (item.IdTipoFlujo != null)
                    {
                        dat.IdTipoFlujo = Convert.ToDecimal(item.IdTipoFlujo);
                    }

                    lM = dat;
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
                throw new Exception(ex.ToString());
            }
        }

        public caj_rpt_Caja_Movimiento_Info Get_Info_MovimientoCaja_Rpt(int IdEmpresa, decimal IdCbteCble, int IdTipoCbte, ref string MensajeError)
        {
                caj_rpt_Caja_Movimiento_Info Datos = new caj_rpt_Caja_Movimiento_Info();
                ct_Cbtecble_det_Data CbteCble_D = new ct_Cbtecble_det_Data();
            try
            {
                Datos.diario = CbteCble_D.Get_list_Cbtecble_det(IdEmpresa, IdTipoCbte, IdCbteCble, ref MensajeError);
                Datos.MovimientoCaja = Get_Info_MovimientoCaja(IdEmpresa, IdCbteCble, IdTipoCbte, ref MensajeError);

                return Datos;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<vwcaj_MovCaja_x_Cobro_Info> Get_list_MovimientosCaja_x_Cobro(int Idempresa, int IdTipocbte_Caja, decimal IdCbteCble_Caja, ref string MensajeError)
        {
            List<vwcaj_MovCaja_x_Cobro_Info> listado = new List<vwcaj_MovCaja_x_Cobro_Info>();
            try
            {
                EntitiesCaja oent = new EntitiesCaja();
                
                var select = from C in oent.vwcaj_MovCaja_x_Cobro
                                                     where C.IdEmpresa == Idempresa
                                                     && C.IdTipocbte == IdTipocbte_Caja
                                                     && C.IdCbteCble == IdCbteCble_Caja
                                                     select C;

                foreach (var item in select)
                {
                    vwcaj_MovCaja_x_Cobro_Info info = new vwcaj_MovCaja_x_Cobro_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdCbteCble = item.IdCbteCble;
                    info.IdTipocbte = item.IdTipocbte;
                    info.IdBanco = item.IdBanco;
                    info.IdCaja = item.IdCaja;
                    info.IdCtaCble_ban = item.IdCtaCble_ban;
                    info.IdCtaCble_TipoCobro = item.IdCtaCble_TipoCobro;
                    info.IdCobro = item.IdCobro;
                    info.IdCobro_tipo = item.IdCobro_tipo;
                    info.dc_ValorPago = item.dc_ValorPago;
                    info.Documento_Cobrado = item.Documento_Cobrado;
                    info.nCliente = item.nCliente;
                    info.nSucursal = item.nSucursal;
                    info.IdPeriodo_Caja = item.IdPeriodo_Caja;
                    info.cr_fecha = item.cr_fecha;
                    info.cr_fechaDocu = item.cr_fechaDocu;
                    info.cr_NumDocumento = item.cr_NumDocumento;
                    info.cr_TotalCobro = item.cr_TotalCobro;
                    info.cm_valor = item.cm_valor;
                    listado.Add(info);
                }
                return listado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<vwcaj_MovCaja_x_Cobro_Info> Get_list_MovimientosCaja_x_Cobro_Anticipo(int Idempresa, int IdTipocbte_Caja, decimal IdCbteCble_Caja, ref string MensajeError)
        {
            List<vwcaj_MovCaja_x_Cobro_Info> listado = new List<vwcaj_MovCaja_x_Cobro_Info>();
            try
            {
                EntitiesCaja oent = new EntitiesCaja();

                var select = from C in oent.vwcaj_MovCaja_x_Cobro_Anticipo
                             where C.IdEmpresa == Idempresa
                             && C.IdTipocbte == IdTipocbte_Caja
                             && C.IdCbteCble == IdCbteCble_Caja
                             select C;

                foreach (var item in select)
                {
                    vwcaj_MovCaja_x_Cobro_Info info = new vwcaj_MovCaja_x_Cobro_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdCbteCble = item.IdCbteCble;
                    info.IdTipocbte = item.IdTipocbte;
                    info.IdBanco = item.IdBanco;
                    info.IdCaja = item.IdCaja;
                    info.IdCtaCble_ban = item.IdCtaCble_ban;
                    info.IdCtaCble_TipoCobro = item.IdCtaCble_TipoCobro;
                    info.IdCobro = item.IdCobro;
                    info.IdCobro_tipo = item.IdCobro_tipo;
                    info.dc_ValorPago = item.cr_TotalCobro;
                    info.Documento_Cobrado = Convert.ToString(item.Documento_Cobrado);
                    info.nCliente = item.nCliente;
                    info.nSucursal = item.nSucursal;
                    info.IdPeriodo_Caja = item.IdPeriodo_Caja;
                    info.cr_fecha = item.cr_fecha;
                    info.cr_fechaDocu = item.cr_fechaDocu;
                    info.cr_NumDocumento = item.cr_NumDocumento;
                    info.cr_TotalCobro = item.cr_TotalCobro;
                    info.cm_valor = item.cm_valor;
                    listado.Add(info);
                }
                return listado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        
        public caj_Caja_Movimiento_Data() { }
    }
}
