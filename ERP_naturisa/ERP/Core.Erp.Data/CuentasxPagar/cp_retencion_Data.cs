using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Info.class_sri.Retencion;
using Core.Erp.Info.class_sri.FacturaV2;
using Core.Erp.Info.class_sri;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_retencion_Data
    {
        string mensaje = "";
        string campoAdicional = null;

        public cp_retencion_Info Get_Info_retencion(int IdEmpresa, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
        {
            try
            {

                cp_retencion_Info lM = new cp_retencion_Info();
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();
                cp_retencion cab = new cp_retencion();
                cab = db.cp_retencion.FirstOrDefault(
                                   C => C.IdEmpresa == IdEmpresa &&
                                   C.IdCbteCble_Ogiro == IdCbteCble_Ogiro
                                   && C.IdTipoCbte_Ogiro == IdTipoCbte_Ogiro);

                if (cab != null)
                {

                    lM.IdEmpresa = cab.IdEmpresa;
                    lM.IdRetencion = cab.IdRetencion;
                    lM.IdTipoCbte_Ogiro = cab.IdTipoCbte_Ogiro;
                    lM.ct_IdCbteCble_Anu = cab.ct_IdCbteCble_Anu;
                    lM.ct_IdEmpresa_Anu = cab.ct_IdEmpresa_Anu;
                    lM.ct_IdTipoCbte_Anu = cab.ct_IdTipoCbte_Anu;
                    lM.Estado = cab.Estado;
                    lM.fecha = cab.fecha;
                    lM.Fecha_Transac = cab.Fecha_Transac;
                    lM.IdCbteCble_Ogiro = cab.IdCbteCble_Ogiro;
                    lM.NAutorizacion = cab.NAutorizacion;
                    lM.NumRetencion = cab.NumRetencion;
                    lM.observacion = cab.observacion;
                    lM.re_Tiene_RFuente = cab.re_Tiene_RFuente;
                    lM.re_Tiene_RTiva = cab.re_Tiene_RTiva;
                    lM.serie1 = cab.serie1; 
                    lM.serie2 = cab.serie2;
                    lM.re_EstaImpresa = cab.re_EstaImpresa;
                    lM.IdEmpresa_Ogiro = cab.IdEmpresa_Ogiro;
                    lM.CodDocumentoTipo = cab.CodDocumentoTipo;

                    lM.IdUsuario = cab.IdUsuario;
                    lM.Fecha_Transac = cab.Fecha_Transac;
                    lM.Estado_Auto =(string.IsNullOrEmpty(cab.NAutorizacion))?"":"AUTORIZADA";



                    lM.ListDetalle = new List<cp_retencion_det_Info>();

                    var select_ = (from T in db.cp_retencion_det
                                   join C in db.cp_codigo_SRI on new { T.IdCodigo_SRI } equals new { C.IdCodigo_SRI }
                                   where T.IdEmpresa == IdEmpresa && T.IdRetencion == lM.IdRetencion
                                   //select T 
                                   select new
                                   {
                                       T.Fecha_Transac,
                                       T.Fecha_UltAnu,
                                       T.Fecha_UltMod,
                                       //  T.IdCbteCble_Ogiro,
                                       T.IdCodigo_SRI,
                                       //  T.IdCtaCble,
                                       T.IdEmpresa,
                                       T.IdRetencion,
                                       T.Idsecuencia,
                                       //  T.IdTipoCbte_Ogiro,
                                       T.IdUsuario,
                                       T.IdUsuarioUltAnu,
                                       T.IdUsuarioUltMod,
                                       T.ip,
                                       T.nom_pc,
                                       T.re_baseRetencion,
                                       T.re_Codigo_impuesto,
                                       T.re_estado,
                                       T.re_Porcen_retencion,
                                       T.re_tipoRet,
                                       T.re_valor_retencion,
                                       C.codigoSRI,
                                       //  T.re_Autorizacion
                                   }
                                  );

                    foreach (var item in select_)
                    {
                        cp_retencion_det_Info dat = new cp_retencion_det_Info();
                        dat.IdEmpresa = item.IdEmpresa;
                        dat.Idsecuencia = item.Idsecuencia;
                        dat.IdRetencion = item.IdRetencion;
                        dat.re_tipoRet = item.re_tipoRet;
                        dat.re_baseRetencion = item.re_baseRetencion;
                        dat.IdCodigo_SRI = item.IdCodigo_SRI;
                        dat.re_Codigo_impuesto = item.re_Codigo_impuesto;
                        dat.re_Porcen_retencion = item.re_Porcen_retencion;
                        dat.re_valor_retencion = item.re_valor_retencion;
                        dat.re_estado = item.re_estado;
                        dat.IdUsuario = item.IdUsuario;
                        dat.Fecha_Transac = item.Fecha_Transac;
                        dat.nom_pc = item.nom_pc;
                        dat.ip = item.ip;
                        dat.CodigoSRI = item.codigoSRI;


                        

                        lM.ListDetalle.Add(dat);
                    }
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public cp_retencion_Info Get_Info_retencion_X_Retecion_FT(int IdEmpresa, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
        {
            try
            {

                cp_retencion_Info lM = new cp_retencion_Info();
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();
                cp_retencion cab = new cp_retencion();
                cab = db.cp_retencion.FirstOrDefault(
                                   C => C.IdEmpresa == IdEmpresa &&
                                   C.IdCbteCble_Ogiro == IdCbteCble_Ogiro
                                   && C.IdTipoCbte_Ogiro == IdTipoCbte_Ogiro
                                   );

                if (cab != null)
                {

                    lM.IdEmpresa = cab.IdEmpresa;
                    lM.IdRetencion = cab.IdRetencion;
                    lM.IdTipoCbte_Ogiro = cab.IdTipoCbte_Ogiro;
                    lM.ct_IdCbteCble_Anu = cab.ct_IdCbteCble_Anu;
                    lM.ct_IdEmpresa_Anu = cab.ct_IdEmpresa_Anu;
                    lM.ct_IdTipoCbte_Anu = cab.ct_IdTipoCbte_Anu;
                    lM.Estado = cab.Estado;
                    lM.fecha = cab.fecha;
                    lM.Fecha_Transac = cab.Fecha_Transac;
                    lM.IdCbteCble_Ogiro = cab.IdCbteCble_Ogiro;
                    lM.NAutorizacion = cab.NAutorizacion;
                    lM.NumRetencion = cab.NumRetencion;
                    lM.observacion = cab.observacion;
                    lM.re_Tiene_RFuente = cab.re_Tiene_RFuente;
                    lM.re_Tiene_RTiva = cab.re_Tiene_RTiva;
                    lM.serie1 = cab.serie1;
                    lM.serie2 = cab.serie2;
                    lM.re_EstaImpresa = cab.re_EstaImpresa;
                    lM.IdEmpresa_Ogiro = cab.IdEmpresa_Ogiro;
                    lM.CodDocumentoTipo = cab.CodDocumentoTipo;
                    lM.ListDetalle = new List<cp_retencion_det_Info>();

                    var select_ = (from T in db.cp_retencion_det
                                   join C in db.cp_codigo_SRI on new { T.IdCodigo_SRI } equals new { C.IdCodigo_SRI }
                                   where T.IdEmpresa == IdEmpresa && T.IdRetencion == lM.IdRetencion && C.IdTipoSRI == "COD_RET_FUE"
                                   select new
                                   {
                                       T.Fecha_Transac,
                                       T.Fecha_UltAnu,
                                       T.Fecha_UltMod,
                                       T.IdCodigo_SRI,
                                       T.IdEmpresa,
                                       T.IdRetencion,
                                       T.Idsecuencia,
                                       T.IdUsuario,
                                       T.IdUsuarioUltAnu,
                                       T.IdUsuarioUltMod,
                                       T.ip,
                                       T.nom_pc,
                                       T.re_baseRetencion,
                                       T.re_Codigo_impuesto,
                                       T.re_estado,
                                       T.re_Porcen_retencion,
                                       T.re_tipoRet,
                                       T.re_valor_retencion,
                                       C.codigoSRI,
                                   }
                                  );

                    foreach (var item in select_)
                    {                        
                        cp_retencion_det_Info dat = new cp_retencion_det_Info();
                        dat.IdEmpresa = item.IdEmpresa;
                        dat.Idsecuencia = item.Idsecuencia;
                        dat.IdRetencion = item.IdRetencion;
                        dat.re_tipoRet = item.re_tipoRet;
                        dat.re_baseRetencion = item.re_baseRetencion;
                        dat.IdCodigo_SRI = item.IdCodigo_SRI;
                        dat.re_Codigo_impuesto = item.re_Codigo_impuesto;
                        dat.re_Porcen_retencion = item.re_Porcen_retencion;
                        dat.re_valor_retencion = item.re_valor_retencion;
                        dat.re_estado = item.re_estado;
                        dat.IdUsuario = item.IdUsuario;
                        dat.Fecha_Transac = item.Fecha_Transac;
                        dat.nom_pc = item.nom_pc;
                        dat.ip = item.ip;
                        dat.CodigoSRI = item.codigoSRI;


                        lM.ListDetalle.Add(dat);
                    }
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public cp_retencion_Info Get_Info_retencion_X_Retecion_RTIVA(int IdEmpresa, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
        {
            try
            {

                cp_retencion_Info lM = new cp_retencion_Info();
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();
                cp_retencion cab = new cp_retencion();
                cab = db.cp_retencion.FirstOrDefault(
                                   C => C.IdEmpresa == IdEmpresa &&
                                   C.IdCbteCble_Ogiro == IdCbteCble_Ogiro
                                   && C.IdTipoCbte_Ogiro == IdTipoCbte_Ogiro
                                   );

                if (cab != null)
                {

                    lM.IdEmpresa = cab.IdEmpresa;
                    lM.IdRetencion = cab.IdRetencion;
                    lM.IdTipoCbte_Ogiro = cab.IdTipoCbte_Ogiro;
                    lM.ct_IdCbteCble_Anu = cab.ct_IdCbteCble_Anu;
                    lM.ct_IdEmpresa_Anu = cab.ct_IdEmpresa_Anu;
                    lM.ct_IdTipoCbte_Anu = cab.ct_IdTipoCbte_Anu;
                    lM.Estado = cab.Estado;
                    lM.fecha = cab.fecha;
                    lM.Fecha_Transac = cab.Fecha_Transac;
                    lM.IdCbteCble_Ogiro = cab.IdCbteCble_Ogiro;
                    lM.NAutorizacion = cab.NAutorizacion;
                    lM.NumRetencion = cab.NumRetencion;
                    lM.observacion = cab.observacion;
                    lM.re_Tiene_RFuente = cab.re_Tiene_RFuente;
                    lM.re_Tiene_RTiva = cab.re_Tiene_RTiva;
                    lM.serie1 = cab.serie1;
                    lM.serie2 = cab.serie2;
                    lM.re_EstaImpresa = cab.re_EstaImpresa;
                    lM.IdEmpresa_Ogiro = cab.IdEmpresa_Ogiro;
                    lM.CodDocumentoTipo = cab.CodDocumentoTipo;
                    lM.ListDetalle = new List<cp_retencion_det_Info>();

                    var select_ = (from T in db.cp_retencion_det
                                   join C in db.cp_codigo_SRI on new { T.IdCodigo_SRI } equals new { C.IdCodigo_SRI }
                                   where T.IdEmpresa == IdEmpresa && T.IdRetencion == lM.IdRetencion && C.IdTipoSRI == "COD_RET_IVA"
                                   select new
                                   {
                                       T.Fecha_Transac,
                                       T.Fecha_UltAnu,
                                       T.Fecha_UltMod,
                                       T.IdCodigo_SRI,
                                       T.IdEmpresa,
                                       T.IdRetencion,
                                       T.Idsecuencia,
                                       T.IdUsuario,
                                       T.IdUsuarioUltAnu,
                                       T.IdUsuarioUltMod,
                                       T.ip,
                                       T.nom_pc,
                                       T.re_baseRetencion,
                                       T.re_Codigo_impuesto,
                                       T.re_estado,
                                       T.re_Porcen_retencion,
                                       T.re_tipoRet,
                                       T.re_valor_retencion,
                                       C.codigoSRI,
                                   }
                                  );

                    foreach (var item in select_)
                    {
                        cp_retencion_det_Info dat = new cp_retencion_det_Info();
                        dat.IdEmpresa = item.IdEmpresa;
                        dat.Idsecuencia = item.Idsecuencia;
                        dat.IdRetencion = item.IdRetencion;
                        dat.re_tipoRet = item.re_tipoRet;
                        dat.re_baseRetencion = item.re_baseRetencion;
                        dat.IdCodigo_SRI = item.IdCodigo_SRI;
                        dat.re_Codigo_impuesto = item.re_Codigo_impuesto;
                        dat.re_Porcen_retencion = item.re_Porcen_retencion;
                        dat.re_valor_retencion = item.re_valor_retencion;
                        dat.re_estado = item.re_estado;
                        dat.IdUsuario = item.IdUsuario;
                        dat.Fecha_Transac = item.Fecha_Transac;
                        dat.nom_pc = item.nom_pc;
                        dat.ip = item.ip;
                        dat.CodigoSRI = item.codigoSRI;


                        lM.ListDetalle.Add(dat);
                    }
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public cp_retencion_Info Get_Info_retencion(int IdEmpresa, decimal IdRetencion)
        {
            try
            {

                cp_retencion_Info lM = new cp_retencion_Info();
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();
                cp_retencion cab = new cp_retencion();
                cab = db.cp_retencion.FirstOrDefault(
                                   C => C.IdEmpresa == IdEmpresa &&
                                   C.IdRetencion == IdRetencion);

                if (cab != null)
                {

                    lM.IdEmpresa = cab.IdEmpresa;
                    lM.IdRetencion = cab.IdRetencion;
                    lM.IdTipoCbte_Ogiro = cab.IdTipoCbte_Ogiro;
                    lM.ct_IdCbteCble_Anu = cab.ct_IdCbteCble_Anu;
                    lM.ct_IdEmpresa_Anu = cab.ct_IdEmpresa_Anu;
                    lM.ct_IdTipoCbte_Anu = cab.ct_IdTipoCbte_Anu;
                    lM.Estado = cab.Estado;
                    lM.fecha = cab.fecha;
                    lM.Fecha_Transac = cab.Fecha_Transac;
                    lM.IdCbteCble_Ogiro = cab.IdCbteCble_Ogiro;
                    lM.NAutorizacion = cab.NAutorizacion;
                    lM.NumRetencion = cab.NumRetencion;
                    lM.observacion = cab.observacion;
                    lM.re_Tiene_RFuente = cab.re_Tiene_RFuente;
                    lM.re_Tiene_RTiva = cab.re_Tiene_RTiva;
                    lM.serie1 = cab.serie1;
                    lM.serie2 = cab.serie2;
                    lM.re_EstaImpresa = cab.re_EstaImpresa;
                    lM.IdEmpresa_Ogiro = cab.IdEmpresa_Ogiro;
                    lM.CodDocumentoTipo = cab.CodDocumentoTipo;
                    lM.ListDetalle = new List<cp_retencion_det_Info>();

                    var select_ = (from T in db.cp_retencion_det
                                   join C in db.cp_codigo_SRI on new { T.IdCodigo_SRI } equals new { C.IdCodigo_SRI }
                                   where T.IdEmpresa == IdEmpresa && T.IdRetencion == lM.IdRetencion
                                   //select T 
                                   select new
                                   {
                                       T.Fecha_Transac,
                                       T.Fecha_UltAnu,
                                       T.Fecha_UltMod,
                                       //  T.IdCbteCble_Ogiro,
                                       T.IdCodigo_SRI,
                                       //  T.IdCtaCble,
                                       T.IdEmpresa,
                                       T.IdRetencion,
                                       T.Idsecuencia,
                                       //  T.IdTipoCbte_Ogiro,
                                       T.IdUsuario,
                                       T.IdUsuarioUltAnu,
                                       T.IdUsuarioUltMod,
                                       T.ip,
                                       T.nom_pc,
                                       T.re_baseRetencion,
                                       T.re_Codigo_impuesto,
                                       T.re_estado,
                                       T.re_Porcen_retencion,
                                       T.re_tipoRet,
                                       T.re_valor_retencion,
                                       C.codigoSRI
                                       //  T.re_Autorizacion
                                   }
                                  );

                    foreach (var item in select_)
                    {
                        cp_retencion_det_Info dat = new cp_retencion_det_Info();
                        dat.IdEmpresa = item.IdEmpresa;
                        dat.Idsecuencia = item.Idsecuencia;
                        dat.IdRetencion = item.IdRetencion;
                        dat.re_tipoRet = item.re_tipoRet;
                        dat.re_baseRetencion = item.re_baseRetencion;
                        dat.IdCodigo_SRI = item.IdCodigo_SRI;
                        dat.re_Codigo_impuesto = item.re_Codigo_impuesto;
                        dat.re_Porcen_retencion = item.re_Porcen_retencion;
                        dat.re_valor_retencion = item.re_valor_retencion;
                        dat.re_estado = item.re_estado;
                        dat.IdUsuario = item.IdUsuario;
                        dat.Fecha_Transac = item.Fecha_Transac;
                        dat.nom_pc = item.nom_pc;
                        dat.ip = item.ip;
                        dat.CodigoSRI = item.codigoSRI;


                        lM.ListDetalle.Add(dat);
                    }
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<cp_retencion_Info> Get_List_retencion(int IdEmpresa)
        {
            try
            {
                List<cp_retencion_Info> lista = new List<cp_retencion_Info>();
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();
                
                var consulta=from q in db.vwcp_retencion
                             where q.IdEmpresa==IdEmpresa

                             select q;
                foreach (var item in consulta)
                {
                    cp_retencion_Info info = new cp_retencion_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdRetencion = item.IdRetencion;
                    info.IdEmpresa_Ogiro = item.IdEmpresa_Ogiro;
                    info.IdCbteCble_Ogiro =item.IdCbte_CXP;
                    info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                    info.Factura_Prov = item.Factura_Prov;
                    info.co_FechaFactura =item.co_FechaFactura;                   
                    info.NumRetencion = item.NumeroRT;
                    info.fecha = item.Fecha_RT;
                    info.NAutorizacion = item.AutorizacionRT;
                    info.Estado = item.EstadoRT;
                    info.re_EstaImpresa = item.ImpresaRT;
                    info.observacion = item.observacionRT;
                    info.re_Tiene_RTiva = item.re_Tiene_RTiva;
                    info.re_Tiene_RFuente = item.re_Tiene_RFuente;
                    info.IdProveedor = item.IdProveedor;
                    info.NomProveedor = item.Nombre_Prov;
                    info.Tipo_Documento = item.Descripcion;
                    info.Total_Retencion = item.Total_Retencion;
                    info.serie1 = item.serie;
                    info.serie2 = item.serie;
                    info.NumRetencion = item.NumRetencion;                                                       
                    lista.Add(info);
                    
                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }                      
        }

        public List<cp_retencion_Info> Get_List_retencion(int IdEmpresa,DateTime Fechaini,DateTime FechaFin)
        {
            try
            {

                Fechaini = Convert.ToDateTime(Fechaini.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                List<cp_retencion_Info> lista = new List<cp_retencion_Info>();
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();

                var consulta = from q in db.vwcp_retencion
                               where q.IdEmpresa == IdEmpresa
                               && q.Fecha_RT >= Fechaini && q.Fecha_RT <= FechaFin
                               select q;
                foreach (var item in consulta)
                {
                    cp_retencion_Info info = new cp_retencion_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdRetencion = item.IdRetencion;
                    info.IdEmpresa_Ogiro = item.IdEmpresa_Ogiro;
                    info.IdCbteCble_Ogiro = item.IdCbte_CXP;
                    info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                    info.Factura_Prov = item.Factura_Prov;
                    info.co_FechaFactura = item.co_FechaFactura;
                    info.NumRetencion = item.NumeroRT;
                    info.fecha = item.Fecha_RT;
                    info.NAutorizacion = item.AutorizacionRT;
                    info.Estado = item.EstadoRT;
                    info.re_EstaImpresa = item.ImpresaRT;
                    info.observacion = item.observacionRT;
                    info.re_Tiene_RTiva = item.re_Tiene_RTiva;
                    info.re_Tiene_RFuente = item.re_Tiene_RFuente;
                    info.IdProveedor = item.IdProveedor;
                    info.NomProveedor = item.Nombre_Prov;
                    info.Tipo_Documento = item.Descripcion;
                    info.Total_Retencion = item.Total_Retencion;
                    info.serie1 = item.serie == null ? null : item.serie.Substring(0, 3);
                    info.serie2 = item.serie == null ? null : item.serie.Substring(4, 3);
                    info.S_Serie = item.serie;
                    info.NumRetencion = item.NumRetencion;
                    info.IdUsuario = item.IdUsuario;
                    info.Fecha_Transac = item.Fecha_Transac;
                    info.Fecha_Autorizacion = item.Fecha_Autorizacion;
                    info.Estado_Auto = (string.IsNullOrEmpty(item.AutorizacionRT)) ? "" : "AUTORIZADA";
                    lista.Add(info);

                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<vwcp_orden_giro_sin_retenciones_Info> Get_List_cp_orden_giro_sin_retenciones(int IdEmpresa, DateTime FechaDesde, DateTime FechaHasta)
        {
            try
            {
                List<vwcp_orden_giro_sin_retenciones_Info> lista = new List<vwcp_orden_giro_sin_retenciones_Info>();
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();

                var consulta = from q in db.vwcp_orden_giro_sin_retenciones
                               where q.IdEmpresa == IdEmpresa && q.co_fechaOg >= FechaDesde && q.co_fechaOg <= FechaHasta
                               && q.Estado=="A"
                               orderby q.IdCbteCble_Ogiro descending

                               select q;
                foreach (var item in consulta)
                {
                    vwcp_orden_giro_sin_retenciones_Info info = new vwcp_orden_giro_sin_retenciones_Info();
                   
                    info.Idempresa=item.IdEmpresa;
                    info.IdCbteCble_Ogiro=item.IdCbteCble_Ogiro;
                    info.IdTipoCbte_Ogiro=item.IdTipoCbte_Ogiro;
                    info.IdOrden_giro_Tipo=item.IdOrden_giro_Tipo;
                    info.IdProveedor=item.IdProveedor;
                    info.co_fechaOg=item.co_fechaOg; 
                    info.co_serie=item.co_serie; 
                    info.co_factura=item.co_factura; 
                    info.co_FechaFactura=item.co_FechaFactura; 
                    info.co_FechaFactura_vct=item.co_FechaFactura_vct; 
                    info.co_plazo=item.co_plazo; 
                    info.co_observacion=item.co_observacion; 
                    info.co_subtotal_iva=item.co_subtotal_iva; 
                    info.co_subtotal_siniva=item.co_subtotal_siniva;   
                    info.co_baseImponible=item.co_baseImponible; 
                    info.co_Por_iva=item.co_Por_iva; 
                    info.co_valoriva=item.co_valoriva; 
                    info.IdCod_ICE=Convert.ToInt32(item.IdCod_ICE); 
                    info.co_Ice_base=item.co_Ice_base; 
                    info.co_Ice_por=item.co_Ice_por; 
                    info.co_Ice_valor=item.co_Ice_valor; 
                    info.co_Serv_por=item.co_Serv_por; 
                    info.co_Serv_valor=item.co_Serv_valor; 
                    info.co_OtroValor_a_descontar=item.co_OtroValor_a_descontar;
                    info.co_OtroValor_a_Sumar=item.co_OtroValor_a_Sumar; 
                    info.co_BaseSeguro=item.co_BaseSeguro; 
                    info.co_total=item.co_total; 
                    info.co_valorpagar=item.co_valorpagar; 
                    info.co_vaCoa=item.co_vaCoa; 
                  //  info.IdAutorizacion=Convert.ToDecimal(item.IdAutorizacion); 
                    info.IdIden_credito=Convert.ToInt32(item.IdIden_credito); 
                    info.IdCod_101=Convert.ToInt32(item.IdCod_101); 
                    info.IdTipoServicio=item.IdTipoServicio; 
                    info.IdCtaCble_Gasto=item.IdCtaCble_Gasto; 
                    info.IdCtaCble_IVA=item.IdCtaCble_IVA; 
                    info.IdUsuario=item.IdUsuario;
                    info.Fecha_Transac = DateTime.Now;
                    info.Estado=item.Estado; 
                    info.IdUsuarioUltMod=item.IdUsuarioUltMod; 
                    info.Fecha_UltMod=Convert.ToDateTime(item.Fecha_UltMod);
                    info.IdUsuarioUltAnu = item.IdUsuarioUltAnu; 
                    info.MotivoAnu=item.MotivoAnu; 
                    info.nom_pc=item.nom_pc; 
                    info.ip=item.ip; 
                    info.Fecha_UltAnu=Convert.ToDateTime(item.Fecha_UltAnu); 
                    info.co_retencionManual=item.co_retencionManual; 
                    info.IdCbteCble_Anulacion=Convert.ToDecimal(item.IdCbteCble_Anulacion); 
                    info.IdTipoCbte_Anulacion=Convert.ToInt32(item.IdTipoCbte_Anulacion); 
                    info.SaldoOG=Convert.ToDecimal(item.SaldoOG); 
                    info.em_nombre=item.em_nombre; 
                    info.IdCentroCosto=item.IdCentroCosto; 
                    info.tc_TipoCbte=item.tc_TipoCbte; 
                    info.IdSucursal=Convert.ToInt32(item.IdSucursal); 
                    info.Sucursal=item.Sucursal; 
                    info.IdTipoFlujo=Convert.ToDecimal(item.IdTipoFlujo); 
                    info.TipoFlujo=item.TipoFlujo; 
                    info.PagoLocExt=item.PagoLocExt; 
                    info.PaisPago=item.PaisPago; 
                    info.PagoSujetoRetencion=item.PagoSujetoRetencion; 
                    info.ConvenioTributacion=item.ConvenioTributacion; 
                    info.co_FechaContabilizacion=Convert.ToDateTime(item.co_FechaContabilizacion); 
                    info.BseImpNoObjDeIva=Convert.ToDouble(item.BseImpNoObjDeIva);
                    info.pr_nombre = item.pr_nombre;

                    info.Tipo_Documento = item.Tipo_Documento;

                    info.IdCtaCble_CXP = item.IdCtaCble_CXP;
                                                                             
                    lista.Add(info);
                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public cp_retencion_x_ct_cbtecble_Info Get_Info_retencion_x_ct_cbtecble(int IdEmpresa, decimal IdCbteCble, int IdTipoCbte)
        {
            cp_retencion_x_ct_cbtecble_Info info = new cp_retencion_x_ct_cbtecble_Info();
            try
            {
                
                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();

                cp_retencion_x_ct_cbtecble registro = db.cp_retencion_x_ct_cbtecble.First
                 (reg => reg.rt_IdEmpresa == IdEmpresa &&
                 reg.ct_IdTipoCbte == IdTipoCbte &&
                 reg.ct_IdCbteCble == IdCbteCble);

                info.ct_IdCbteCble = registro.ct_IdCbteCble;
                info.ct_IdEmpresa = registro.ct_IdEmpresa;
                info.ct_IdTipoCbte = registro.ct_IdTipoCbte;
                info.Observacion = registro.Observacion;
               // info.rt_IdCbteCble_Ogiro = registro.rt_IdCbteCble_Ogiro;
                info.rt_IdEmpresa = registro.rt_IdEmpresa;
                info.rt_IdRetencion = registro.rt_IdRetencion;
             //   info.rt_IdTipoCbte_Ogiro = registro.rt_IdTipoCbte_Ogiro;

                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public cp_retencion_x_ct_cbtecble_Info Get_Info_retencion_x_ct_cbtecble(int IdEmpresa, decimal IdRetencion)
        {
            cp_retencion_x_ct_cbtecble_Info info = new cp_retencion_x_ct_cbtecble_Info();
            try
            {

                EntitiesCuentasxPagar db = new EntitiesCuentasxPagar();
            
                cp_retencion_x_ct_cbtecble registro = db.cp_retencion_x_ct_cbtecble.First
                 (reg => reg.rt_IdEmpresa == IdEmpresa &&
                 reg.rt_IdRetencion == IdRetencion);
                info.ct_IdCbteCble = registro.ct_IdCbteCble;
                info.ct_IdEmpresa = registro.ct_IdEmpresa;
                info.ct_IdTipoCbte = registro.ct_IdTipoCbte;
                info.Observacion = registro.Observacion;               
                info.rt_IdEmpresa = registro.rt_IdEmpresa;
                info.rt_IdRetencion = registro.rt_IdRetencion;
              
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                info = new cp_retencion_x_ct_cbtecble_Info();
            }
            return info;
        }

        public decimal GetIdRetencion(int IdEmpresa)
        {
            decimal Id;
            try
            {
                EntitiesCuentasxPagar base_ = new EntitiesCuentasxPagar();

                Id = base_.cp_retencion.Count(C => C.IdEmpresa == IdEmpresa);
                
                if (Id == 0)
                    Id = 1;
                else
                {
                   decimal select_ = (from C in base_.cp_retencion
                                      where C.IdEmpresa == IdEmpresa
                                       select C.IdRetencion).Max();
                    Id = select_ + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
      
        public Boolean GrabarDB_Ret_CbteCble(cp_retencion_x_ct_cbtecble_Info TI, ref string mensaje)
        {
            try
            {
                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    cp_retencion_x_ct_cbtecble address = new cp_retencion_x_ct_cbtecble();
                    address.ct_IdCbteCble = TI.ct_IdCbteCble;
                    address.ct_IdEmpresa = TI.ct_IdEmpresa;
                    address.ct_IdTipoCbte = TI.ct_IdTipoCbte;
                    address.Observacion = TI.Observacion;
                  //  address.rt_IdCbteCble_Ogiro = TI.rt_IdCbteCble_Ogiro;
                    address.rt_IdEmpresa = TI.rt_IdEmpresa;
                    address.rt_IdRetencion = TI.rt_IdRetencion;
                  //  address.rt_IdTipoCbte_Ogiro = TI.rt_IdTipoCbte_Ogiro;
                    Context.cp_retencion_x_ct_cbtecble.Add(address);
                    Context.SaveChanges();               
                
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GrabarDB(cp_retencion_Info info)
        {
            Boolean res = false;
            try
            {

                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    EntitiesCuentasxPagar EDB = new EntitiesCuentasxPagar();
                    var address = new cp_retencion();

                    address.IdEmpresa = info.IdEmpresa;
                   
                    address.IdEmpresa_Ogiro = info.IdEmpresa_Ogiro == null ? info.IdEmpresa : info.IdEmpresa_Ogiro;
                    
                    address.IdCbteCble_Ogiro = info.IdCbteCble_Ogiro;
                    address.IdTipoCbte_Ogiro = info.IdTipoCbte_Ogiro;
                    address.IdRetencion = info.IdRetencion = GetIdRetencion(info.IdEmpresa);

                    address.CodDocumentoTipo = (info.CodDocumentoTipo == null) ? "RETEN" : info.CodDocumentoTipo;
                    address.serie1 = null;//Al grabar debe mandarse en null hasta que se imprima.
                    address.serie2 = null;//Al grabar debe mandarse en null hasta que se imprima.
                    address.NumRetencion = null;//Al grabar debe mandarse en null hasta que se imprima.
                    address.NAutorizacion = null;//Al grabar debe mandarse en null hasta que se imprima.
                   
                    address.observacion = (info.observacion== null)?"":
                        (info.observacion.Length>500)? info.observacion.Substring(0,500) :info.observacion;
                    address.fecha = Convert.ToDateTime(info.fecha.ToShortDateString());

                    var countRET_Iva = info.ListDetalle.FirstOrDefault(v => v.re_tipoRet == "IVA");
                    var countRET_Ft = info.ListDetalle.FirstOrDefault(v => v.re_tipoRet == "RTF");

                    address.re_Tiene_RTiva = (countRET_Iva == null) ? "N" : "S";
                    address.re_Tiene_RFuente = (countRET_Ft == null) ? "N" : "S";
                    address.re_EstaImpresa = (info.re_EstaImpresa == null) ? "N" : info.re_EstaImpresa;

                    address.Estado = "A";
                    address.Fecha_Transac = DateTime.Now;
                    address.IdUsuario = info.IdUsuario == null ? "" : info.IdUsuario;
                    address.nom_pc = info.nom_pc;
                    address.ip = info.ip;
                    
                    context.cp_retencion.Add(address);
                    context.SaveChanges();
                    info.IdRetencion = address.IdRetencion;
                }
                info.ListDetalle.ForEach(var => var.IdRetencion = info.IdRetencion);

                cp_retencion_det_Data odataDet = new cp_retencion_det_Data();
                res = odataDet.GrabarDB(info.ListDetalle);
                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
     
        public Boolean ActualizarDB(cp_retencion_Info info, ref string msg)
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_retencion.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdRetencion == info.IdRetencion);
                    if (contact != null)
                    {
                        contact.observacion = info.observacion;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        contact.nom_pc = info.nom_pc;
                        contact.ip = info.ip;
                        context.SaveChanges();
                        msg = "Se ha procedido Actualizar La retención # : " + info.IdRetencion.ToString() + " Exitosamente";
                        res = true;
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
  
        public Boolean AnularDB(cp_retencion_Info info, ref string mensaje)
        {
            try
            {
                Boolean res = false;
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_retencion.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdRetencion == info.IdRetencion);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.ct_IdEmpresa_Anu = info.ct_IdEmpresa_Anu;
                        contact.ct_IdCbteCble_Anu = info.ct_IdCbteCble_Anu;
                        contact.ct_IdTipoCbte_Anu = info.ct_IdTipoCbte_Anu;
                        contact.IdTipoCbte_Ogiro = info.IdTipoCbte_Ogiro;
                        contact.IdCbteCble_Ogiro = info.IdCbteCble_Ogiro;
                        contact.IdEmpresa_Ogiro = info.IdEmpresa_Ogiro;
                        contact.observacion = "*ANULADO* "+contact.observacion;
                        
                        contact.MotivoAnulacion = info.MotivoAnulacion;
                        contact.Fecha_UltAnu = info.Fecha_UltAnu;
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        context.SaveChanges();
                        mensaje = "Se procedio anular correctamente la retención#" + info.IdRetencion;
                        res = true;
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
      
        public Boolean VericarNumRetencion(string NumRetencion,string Serie, int IdEmpresa, ref string mensaje ,decimal IdCbteOG=0)
        {
            try
            {
                Boolean Existe;
                mensaje = "";
                Existe = false;

                EntitiesCuentasxPagar B = new EntitiesCuentasxPagar();

                if (IdCbteOG == 0)
                {
                    var select_ = from t in B.cp_retencion
                                  where t.IdEmpresa == IdEmpresa && t.NumRetencion == NumRetencion && t.serie1 == Serie 
                                  group t by new { t.NumRetencion, t.IdEmpresa, t.IdCbteCble_Ogiro } into tg
                                  select new { tg };

                    foreach (var item in select_)
                    {
                        
                        mensaje = mensaje + item.tg.Key.IdCbteCble_Ogiro + " ";
                        Existe = true;
                    }
                }
                else
                {
                    var select_ = from t in B.cp_retencion
                                  where t.IdEmpresa == IdEmpresa && t.NumRetencion == NumRetencion && t.serie1 == Serie && t.IdCbteCble_Ogiro == IdCbteOG
                                  group t by new { t.NumRetencion, t.IdEmpresa, t.IdCbteCble_Ogiro } into tg
                                  select new { tg };


                    foreach (var item in select_)
                    {
                        mensaje = mensaje + item.tg.Key.IdCbteCble_Ogiro + " ";
                        Existe = true;
                    }
                }
                return Existe;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public cp_retencion_Info Get_Retencion_Valores_totales_x_OG(int IdEmpresa, int IdTipoCbteCble, decimal IdCbteCble)
        {
            try
            {
                cp_retencion_Info info = new cp_retencion_Info();

                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    var lst = from q in Context.vwCP_Retencion_Valor_total
                              where IdEmpresa == q.IdEmpresa_Ogiro
                              && IdTipoCbteCble == q.IdTipoCbte_Ogiro
                              && IdCbteCble == q.IdCbteCble_Ogiro
                              select q;
                    foreach (var item in lst)
                    {
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdRetencion = item.IdRetencion;
                        info.IdEmpresa_Ogiro = item.IdEmpresa_Ogiro;
                        info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        info.Total_Retencion = item.Total_Retencion;
                    }
                }
                return info;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public Boolean VericarNumRetencion(string NumRetencion, string Serie, int IdEmpresa, int IdEmpresa_OG, decimal IdCbteCble_OG, int IdTipoCbte_OG, ref string mensaje)
        {

            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {

                    NumRetencion = NumRetencion.Trim();
                    Serie = Serie.Trim();
                    var result = from q in context.cp_retencion
                                 where q.IdEmpresa == IdEmpresa && q.NumRetencion == NumRetencion && q.serie1 == Serie
                                 && q.IdEmpresa_Ogiro == IdEmpresa_OG && q.IdCbteCble_Ogiro == IdCbteCble_OG && q.IdTipoCbte_Ogiro == IdTipoCbte_OG
                                 select q;

                    if (result.Count() != 0)
                    {
                        return true;
                    }
                    else
                    { return false; }

                              
                }

            }
            catch (Exception ex)
            {
                
                 string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        
        }

        public Boolean Modificar_Num_Retencion(cp_retencion_Info info, ref string mensaje)
        {
            try
            {
                Boolean res = false;
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
                cp_retencion reg = new cp_retencion();
                reg = context.cp_retencion.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa 
                    && minfo.IdCbteCble_Ogiro == info.IdCbteCble_Ogiro 
                    && minfo.IdTipoCbte_Ogiro == info.IdTipoCbte_Ogiro 
                    && minfo.IdRetencion == info.IdRetencion);

                if (reg != null)
                {
                    var countRET_Iva = info.ListDetalle.FirstOrDefault(v => v.re_tipoRet == "IVA");
                    var countRET_Ft = info.ListDetalle.FirstOrDefault(v => v.re_tipoRet == "RTF");

                    reg.re_Tiene_RTiva = (countRET_Iva == null) ? "N" : "S";
                    reg.re_Tiene_RFuente  = (countRET_Ft == null) ? "N" : "S";

                    reg.fecha = info.fecha;
                    reg.observacion = (String.IsNullOrEmpty(info.observacion) ? "" : info.observacion.Trim());
                    reg.re_EstaImpresa = (info.re_EstaImpresa == null) ? "N" : info.re_EstaImpresa;
                    
                    reg.serie1 = info.serie1;
                    reg.serie2 = info.serie2;
                    reg.CodDocumentoTipo = (info.CodDocumentoTipo == null) ? "RETEN" : info.CodDocumentoTipo;
                    reg.NumRetencion = info.NumRetencion;
                    ////////////////////
                    reg.NAutorizacion = info.NAutorizacion;
                    reg.Fecha_UltMod = info.Fecha_UltMod;
                    reg.IdUsuarioUltAnu = info.IdUsuarioUltMod;
                    context.SaveChanges();
                    res = true;
                }
                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<comprobanteRetencion> GenerarXmlRetencion(int IdEmpresa, decimal IdRetencion, ref string msg)
        {

            try
            {
                string secuencia_aux = "";
                string secuencia = "";
                
                List<comprobanteRetencion> lista = new List<comprobanteRetencion>();             
                EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();               
                IQueryable<vwcp_Retencion_sri_Info> consulta = from selec in ECXP.vwcp_Retencion_sri
                                                               where selec.IdEmpresa == IdEmpresa
                                                                      && selec.IdRetencion == IdRetencion
                select new vwcp_Retencion_sri_Info
                {                                                                 
                   IdEmpresa =selec.IdEmpresa,IdRetencion =selec.IdRetencion,serie =selec.serie,
                   NumRetencion=selec.NumRetencion, fecha =selec.fecha, pe_nombreCompleto =selec.pe_nombreCompleto,                                                                 
                   pe_razonSocial=selec.pe_razonSocial,  pe_cedulaRuc=selec.pe_cedulaRuc, pe_correo =selec.pe_correo,
                   IdProveedor =selec.IdProveedor, co_FechaFactura =selec.co_FechaFactura,pe_direccion =selec.pe_direccion,
                   pe_telfono_Contacto =selec.pe_telfono_Contacto,co_serie =selec.co_serie,co_factura = selec.co_factura,
                   IdOrden_giro_Tipo = selec.IdOrden_giro_Tipo, RazonSocial = selec.RazonSocial, NombreComercial = selec.NombreComercial,
                   ContribuyenteEspecial = selec.ContribuyenteEspecial, ObligadoAllevarConta = selec.ObligadoAllevarConta,
                   em_ruc = selec.em_ruc,em_direccion = selec.em_direccion,IdTipoDocumento = selec.IdTipoDocumento,
                   IdSucursal =selec.IdSucursal,Su_Descripcion =selec.Su_Descripcion,Su_Direccion =selec.Su_Direccion,
                   Estado =selec.Estado
                                           
                };

           

                foreach (var item in consulta)
                {
                    comprobanteRetencion myObjectRete = new comprobanteRetencion();
                    
                    myObjectRete.version = "1.0.0";
                    myObjectRete.idSpecified = true;
                    myObjectRete.infoTributaria = new infoTributaria();
                    myObjectRete.infoCompRetencion = new comprobanteRetencionInfoCompRetencion();
                    myObjectRete.impuestos = new List<Info.class_sri.Retencion.impuesto>();
                    myObjectRete.infoTributaria.ambiente = "1";
                    myObjectRete.infoTributaria.tipoEmision = "1";
                    myObjectRete.infoTributaria.razonSocial = item.RazonSocial.Trim();  //empresa validar
                    myObjectRete.infoTributaria.nombreComercial = item.NombreComercial.Trim(); //empresa validar
                    myObjectRete.infoTributaria.ruc = item.em_ruc.Trim(); //empresa validar
                    myObjectRete.infoTributaria.claveAcceso = "0000000000000000000000000000000000000000000000000";
                    myObjectRete.infoTributaria.codDoc = "07";


                    //validar secuencial retencion
                    secuencia_aux = "";
                    secuencia = "";

                    if (!String.IsNullOrEmpty(item.NumRetencion))
                    {
                        if (item.NumRetencion.Length < 9)
                        {
                            int conta = item.NumRetencion.Length;
                            int diferencia = 9 - conta;

                            secuencia_aux = secuencia_aux.PadLeft(diferencia, '0');
                            secuencia = secuencia_aux + item.NumRetencion;

                            item.NumRetencion = secuencia;

                        }

                    }

                    string[] serie = Convert.ToString(item.serie).Split('-');

                    myObjectRete.infoTributaria.estab = serie[0].Trim();  // retencion
                    myObjectRete.infoTributaria.ptoEmi = serie[1].Trim(); ; // retencion


                    myObjectRete.infoTributaria.secuencial = item.NumRetencion; // retencion validar ceros a la izquierda

                    myObjectRete.infoTributaria.dirMatriz = item.em_direccion.Trim();  //empresa validar


                    myObjectRete.infoCompRetencion.fechaEmision = item.fecha.ToString("dd/MM/yyyy"); // factura


                    myObjectRete.infoCompRetencion.dirEstablecimiento = item.Su_Direccion; ///sucursal
                    myObjectRete.infoCompRetencion.contribuyenteEspecial = item.ContribuyenteEspecial; //empresa   
                    myObjectRete.infoCompRetencion.obligadoContabilidad = (item.ObligadoAllevarConta == "S" || item.ObligadoAllevarConta == "SI") ? "SI" : "NO";

                    switch (item.IdTipoDocumento)
                    {
                        case "CED":
                            myObjectRete.infoCompRetencion.tipoIdentificacionSujetoRetenido = "05";
                            break;
                        case "PAS":
                            myObjectRete.infoCompRetencion.tipoIdentificacionSujetoRetenido = "06";
                            break;

                        case "RUC":
                            myObjectRete.infoCompRetencion.tipoIdentificacionSujetoRetenido = "04";
                            break;
                        default:
                            break;
                    }

                    myObjectRete.infoCompRetencion.razonSocialSujetoRetenido = item.pe_razonSocial.Trim(); // proveedor
                    myObjectRete.infoCompRetencion.identificacionSujetoRetenido = item.pe_cedulaRuc.Trim();  // cedula o ruc
                    myObjectRete.infoCompRetencion.periodoFiscal = Convert.ToString(myObjectRete.infoCompRetencion.fechaEmision).Substring(3, 7); // factura


                    // consultar detalle Retencion

                    cp_retencion_det_Data odata = new cp_retencion_det_Data();
                    List<cp_retencion_det_Info> listaDetReten = new List<cp_retencion_det_Info>();

                    listaDetReten = odata.Get_List_retencion_det_x_Report(IdEmpresa, IdRetencion, ref msg);

                    if (listaDetReten.Count != 0)
                    {

                        foreach (var itemDET in listaDetReten)
                        {
                            Info.class_sri.Retencion.impuesto imp = new Info.class_sri.Retencion.impuesto();

                            if (itemDET.re_tipoRet == "IVA")
                            {
                                imp.codigo = "2";


                                switch (Convert.ToString(itemDET.re_Porcen_retencion))
                                {

                                    case "0" :
                                        imp.codigoRetencion = "8";
                                        imp.porcentajeRetener = 0;
                                        break;
                                    case "10":
                                        imp.codigoRetencion = "9";
                                        imp.porcentajeRetener = 10;
                                        break;
                                    case "20":
                                        imp.codigoRetencion = "10";
                                        imp.porcentajeRetener = 20;
                                        break;
                                    case "30":
                                        imp.codigoRetencion = "1";
                                        imp.porcentajeRetener = 30;
                                        break;
                                    case "50":
                                        imp.codigoRetencion = "11";
                                        imp.porcentajeRetener = 50;
                                        break;
                                    case "70":
                                        imp.codigoRetencion = "2";
                                        imp.porcentajeRetener = 70;
                                        break;
                                    case "100":
                                        imp.codigoRetencion = "3";
                                        imp.porcentajeRetener = 100;
                                        break;
                                    default:
                                        break;
                                }
                            }

                            if (itemDET.re_tipoRet == "RTF")
                            {
                                imp.codigo = "1";
                                imp.codigoRetencion = itemDET.re_Codigo_impuesto;
                                imp.porcentajeRetener = Convert.ToDecimal(itemDET.re_Porcen_retencion);

                            }

                            imp.baseImponible = Math.Round(Convert.ToDecimal(itemDET.re_baseRetencion), 2);
                            imp.valorRetenido = Math.Round(Convert.ToDecimal(itemDET.re_valor_retencion), 2);
                            imp.codDocSustento = item.IdOrden_giro_Tipo;   //si factura es 01 y 

                            // validar secuencial factura
                            secuencia_aux = "";
                            secuencia = "";

                            if (!String.IsNullOrEmpty(item.co_factura))
                            {
                                if (item.co_factura.Length < 9)
                                {
                                    int conta = item.co_factura.Length;
                                    int diferencia = 9 - conta;

                                    secuencia_aux = secuencia_aux.PadLeft(diferencia, '0');
                                    secuencia = secuencia_aux + item.co_factura;

                                    item.co_factura = secuencia;
                                }
                            }
                        
                            string[] serieFact = Convert.ToString(item.co_serie).Split('-');

                            imp.numDocSustento = serieFact[0].Trim() + serieFact[1].Trim() + Convert.ToString(item.co_factura).Trim();
                            imp.fechaEmisionDocSustento = item.co_FechaFactura.ToString("dd/MM/yyyy");

                           // myObjectRete.infoCompRetencion.fechaEmision = item.co_FechaFactura.ToString(format);
                            myObjectRete.impuestos.Add(imp);

                          
                            if(!String.IsNullOrEmpty(item.pe_correo.Trim()))
                            {
                                campoAdicional = item.pe_correo.Trim();
                                // campos adicionales               
                                Cl_ValidarEmail_Info datosAdc = new Cl_ValidarEmail_Info();

                                if (!String.IsNullOrEmpty(campoAdicional))
                                {
                                    if (datosAdc.email_bien_escrito(campoAdicional) == true)
                                    {
                                        comprobanteRetencionCampoAdicional compoadicional = new comprobanteRetencionCampoAdicional();
                                        compoadicional.nombre = "MAIL";
                                        compoadicional.Value = campoAdicional;
                                        myObjectRete.infoAdicional = new List<comprobanteRetencionCampoAdicional>();
                                        myObjectRete.infoAdicional.Add(compoadicional);
                                    }

                                }
                            
                            }

                        }

                    }
                                
                    lista.Add(myObjectRete);
                }

                msg = "Archivo XML de Retención Generado con Exito";
                return lista;

            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                     "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                msg = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<vwcp_Retencion_sri_Info> Get_list_Retencion_Sri(int IdEmpresa, decimal IdRetencion, ref string msg)
        {
            try
            {
                List<vwcp_Retencion_sri_Info> lista = new List<vwcp_Retencion_sri_Info>();

                EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();


                var consulta = from selec in ECXP.vwcp_Retencion_sri
                               where selec.IdEmpresa == IdEmpresa
                                      && selec.IdRetencion == IdRetencion
                               select selec;


                foreach (var item in consulta)
                {

                    vwcp_Retencion_sri_Info info = new vwcp_Retencion_sri_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdRetencion = item.IdRetencion;
                    info.serie = item.serie;
                    info.NumRetencion = item.NumRetencion;
                    info.fecha = item.fecha;
                    info.pe_nombreCompleto = item.pe_nombreCompleto.Trim();
                    info.pe_razonSocial =(item.pe_razonSocial==null)?"": item.pe_razonSocial.Trim();
                    info.pe_cedulaRuc = item.pe_cedulaRuc;
                    info.pe_correo =(item.pe_correo==null)?"": item.pe_correo.Trim();
                    info.IdProveedor = item.IdProveedor;
                    info.co_FechaFactura = item.co_FechaFactura;
                    info.pe_direccion =(item.pe_direccion==null)?"": item.pe_direccion.Trim();
                    info.pe_telfono_Contacto =(item.pe_telfono_Contacto==null)?"": item.pe_telfono_Contacto.Trim();
                    info.co_serie = item.co_serie;
                    info.co_factura = item.co_factura;
                    info.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                    info.RazonSocial = item.RazonSocial.Trim();
                    info.NombreComercial =(item.NombreComercial==null)?"": item.NombreComercial.Trim();
                    info.ContribuyenteEspecial = item.ContribuyenteEspecial.Trim();
                    info.ObligadoAllevarConta = item.ObligadoAllevarConta.Trim();
                    info.em_ruc = item.em_ruc.Trim();
                    info.em_direccion =(item.em_direccion==null)?"": item.em_direccion.Trim();
                    info.IdTipoDocumento = item.IdTipoDocumento.Trim();

                    info.IdSucursal = Convert.ToInt32(item.IdSucursal);
                    info.Su_Descripcion = item.Su_Descripcion.Trim();
                    info.Su_Direccion = item.Su_Direccion.Trim();
                    info.Estado = item.Estado;

                    lista.Add(info);
                }

                return lista;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                     "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                msg = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public Boolean Existe_Retencion(int IdEmpresa, decimal IdRetencion)
        {
            try
            {
                using (EntitiesCuentasxPagar Entity = new EntitiesCuentasxPagar())
                {                   
                    var result = from q in Entity.cp_retencion
                                 where q.IdEmpresa == IdEmpresa && q.IdRetencion == IdRetencion                             
                                 select q;

                    if (result.Count() != 0)
                    {
                        return true;
                    }
                    else
                    { return false; }
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
       
        public cp_retencion_Data() { }
    }
}
