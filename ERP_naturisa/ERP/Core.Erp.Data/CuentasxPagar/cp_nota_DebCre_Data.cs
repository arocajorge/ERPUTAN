using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.Entity.Validation;
namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_nota_DebCre_Data
    {
        string mensaje = "";

        public List<cp_nota_DebCre_Info> Get_List_nota_DebCre(int IdEmpresa, int anio, int mes)
        {
            try
            {
                List<cp_nota_DebCre_Info> lM = new List<cp_nota_DebCre_Info>();
                EntitiesCuentasxPagar Base = new EntitiesCuentasxPagar();
                string msg="";


                var select_ = from T in Base.vwcp_nota_DebCre_ATS
                              where T.IdEmpresa == IdEmpresa 
                              && T.cn_fecha.Year == anio 
                              && T.cn_fecha.Month == mes 
                              && T.Estado=="A"
                              select T;

                foreach (var item in select_)
                {
                    cp_nota_DebCre_Info dat = new cp_nota_DebCre_Info();

                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdCbteCble_Nota = item.IdCbteCble_Nota;
                    dat.IdTipoCbte_Nota = item.IdTipoCbte_Nota;
                    dat.IdProveedor = item.IdProveedor;
                    dat.cn_fecha = item.cn_fecha;
                    dat.cn_serie1 = item.cn_serie1;
                    dat.cn_serie2 = item.cn_serie2;
                    dat.cn_Nota = item.cn_Nota;
                    dat.cn_observacion = item.cn_observacion;
                    dat.cn_subtotal_iva = item.cn_subtotal_iva;
                    dat.cn_subtotal_siniva = item.cn_subtotal_siniva;
                    dat.cn_baseImponible = item.cn_baseImponible;
                    dat.cn_Por_iva = item.cn_Por_iva;
                    dat.cn_valoriva = item.cn_valoriva;
                    dat.IdCod_ICE = item.IdCod_ICE;
                    dat.cn_Ice_base = item.cn_Ice_base;
                    dat.cn_Ice_por = item.cn_Ice_por;
                    dat.cn_Ice_valor = item.cn_Ice_valor;
                    dat.cn_Serv_por = item.cn_Serv_por;
                    dat.cn_Serv_valor = item.cn_Serv_valor;
                    dat.cn_BaseSeguro = item.cn_BaseSeguro;
                    dat.cn_total = item.cn_total;
                    dat.cn_vaCoa = item.cn_vaCoa;
                    dat.cn_Autorizacion = item.cn_Autorizacion;
                    dat.IdTipoServicio = item.IdTipoServicio;
                    dat.IdCtaCble_Acre = item.IdCtaCble_Acre;
                    dat.IdCtaCble_IVA = item.IdCtaCble_IVA;
                    dat.IdUsuario = item.IdUsuario;
                    dat.Fecha_Transac = item.Fecha_Transac;
                    dat.Estado = item.Estado;
                    dat.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    dat.Fecha_UltMod = item.Fecha_UltMod;
                    dat.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    dat.MotivoAnu = item.MotivoAnu;
                    dat.nom_pc = item.nom_pc;
                    dat.ip = item.ip;
                    dat.Fecha_UltAnu = item.Fecha_UltAnu;
                    dat.IdCbteCble_Anulacion = item.IdCbteCble_Anulacion;
                    dat.IdTipoCbte_Anulacion = item.IdTipoCbte_Anulacion;
                    dat.cn_tipoLocacion = item.cn_tipoLocacion;
                    dat.IdCentroCosto = item.IdCentroCosto;
                    dat.IdSucursal = item.IdSucursal;
                    dat.IdTipoFlujo = item.IdTipoFlujo;
                    
                    dat.DebCre = (item.DebCre == "C") ? "Credito" : "Debito";
                    
                    dat.IdIden_credito = item.IdIden_credito;
                    dat.IdTipoNota = item.IdTipoNota;
                    
                    dat.cn_Autorizacion_Imprenta = null;
                    dat.PagoLocExt = item.PagoLocExt;
                    dat.PaisPago = item.PaisPago;
                    dat.ConvenioTributacion = item.ConvenioTributacion;
                    dat.PagoSujetoRetencion = item.PagoSujetoRetencion;
                    
                    dat.fecha_autorizacion = Convert.ToDateTime(item.fecha_autorizacion);

                    dat.Num_Nota = "NT" + item.DebCre + "#:" + item.cn_serie1 + "-" + item.cn_serie2 + "-" + item.cn_Nota;

                    dat.cn_Fecha_vcto = item.cn_Fecha_vcto;

                    dat.InfoProveedor.IdProveedor = item.IdProveedor;

                    dat.InfoProveedor.Persona_Info.IdTipoDocumento = item.IdTipoDocumento;
                    dat.InfoProveedor.Persona_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                    dat.InfoProveedor.Persona_Info.pe_Naturaleza = item.pe_Naturaleza;
                    dat.InfoProveedor.Persona_Info.pe_razonSocial = item.pe_razonSocial;


                    cp_orden_pago_cancelaciones_Data Odata_can= new cp_orden_pago_cancelaciones_Data();
                    cp_orden_pago_cancelaciones_Info Info_cance= new cp_orden_pago_cancelaciones_Info();
                    Info_cance=Odata_can.Get_list_Cancelacion_x_Pagos(dat.IdEmpresa , dat.IdTipoCbte_Nota  ,dat.IdCbteCble_Nota,ref msg).FirstOrDefault();
                    if (Info_cance!=null)
                    {
                        cp_orden_giro_Data OG_data = new cp_orden_giro_Data();
                        cp_orden_giro_Info Info_Og = new cp_orden_giro_Info();
                        Info_Og = OG_data.Get_Info_orden_giro(Convert.ToInt32(Info_cance.IdEmpresa_cxp), Convert.ToInt32(Info_cance.IdTipoCbte_cxp), Convert.ToDecimal(Info_cance.IdCbteCble_cxp));

                        if (Info_Og.IdEmpresa != 0)
                        {
                            dat.docModificado = Info_Og.IdOrden_giro_Tipo;
                            dat.estabModificado = Info_Og.co_serie.Substring(0, 3);
                            dat.ptoEmiModificado = Info_Og.co_serie.Substring(4, 3);
                            dat.secModificado = Info_Og.co_factura;
                            dat.autModificado = Info_Og.Num_Autorizacion;
                            dat.cn_num_doc_modificado = Info_Og.co_factura;
                        }
                        lM.Add(dat);
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<cp_nota_DebCre_Info> Get_List_nota_DebCre(int IdEmpresa)
        {
            try
            {
                List<cp_nota_DebCre_Info> lM = new List<cp_nota_DebCre_Info>();
                EntitiesCuentasxPagar Base = new EntitiesCuentasxPagar();

                var select_ = (from T in Base.vwcp_nota_DebCre
                               where T.IdEmpresa == IdEmpresa
                               select T
                              );

                foreach (var item in select_)
                {
                    cp_nota_DebCre_Info dat = new cp_nota_DebCre_Info();

                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdCbteCble_Nota = item.IdCbteCble_Nota;
                    dat.IdTipoCbte_Nota = item.IdTipoCbte_Nota;
                    dat.IdProveedor = item.IdProveedor;
                    dat.cn_fecha = item.cn_fecha;
                    dat.Fecha_contable = item.Fecha_contable;
                    dat.cn_Fecha_vcto = item.cn_Fecha_vcto;
                    dat.cn_serie1 = item.cn_serie1;
                    dat.cn_serie2 = item.cn_serie2;
                    dat.cn_Nota = item.cn_Nota;
      
                    dat.cn_observacion = item.cn_observacion;
                    dat.cn_subtotal_iva = item.cn_subtotal_iva;
                    dat.cn_subtotal_siniva = item.cn_subtotal_siniva;
                    dat.cn_baseImponible = item.cn_baseImponible;
                    dat.cn_Por_iva = item.cn_Por_iva;
                    dat.cn_valoriva = item.cn_valoriva;
                    dat.IdCod_ICE = item.IdCod_ICE;
                    dat.cn_Ice_base = item.cn_Ice_base;
                    dat.cn_Ice_por = item.cn_Ice_por;
                    dat.cn_Ice_valor = item.cn_Ice_valor;
                    dat.cn_Serv_por = item.cn_Serv_por;
                    dat.cn_Serv_valor = item.cn_Serv_valor;
                    dat.cn_BaseSeguro = item.cn_BaseSeguro;
                    dat.cn_total = item.cn_total;
                    dat.cn_vaCoa = item.cn_vaCoa;
                    dat.cn_Autorizacion = item.cn_Autorizacion;
                    dat.IdTipoServicio = item.IdTipoServicio;
                    dat.IdCtaCble_Acre = item.IdCtaCble_Acre;
                    dat.IdCtaCble_IVA = item.IdCtaCble_IVA;
                    dat.IdUsuario = item.IdUsuario;
                    dat.Fecha_Transac = item.Fecha_Transac;
                    dat.Estado = item.Estado;
                    dat.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    dat.Fecha_UltMod = item.Fecha_UltMod;
                    dat.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    dat.MotivoAnu = item.MotivoAnu;
                    dat.nom_pc = item.nom_pc;
                    dat.ip = item.ip;
                    dat.Fecha_UltAnu = item.Fecha_UltAnu;
                    dat.IdCbteCble_Anulacion = item.IdCbteCble_Anulacion;
                    dat.IdTipoCbte_Anulacion = item.IdTipoCbte_Anulacion;
                    dat.nomProveedor = item.pr_nombre;
                    dat.cn_tipoLocacion = item.cn_tipoLocacion;
                    dat.IdCentroCosto = item.IdCentroCosto;
                    dat.IdSucursal = item.IdSucursal;
                    dat.IdTipoFlujo = item.IdTipoFlujo;
                    dat.DebCre = (item.DebCre == "C") ? "Credito" : "Debito";
                    dat.IdIden_credito = item.IdIden_credito;
                    dat.PagoLocExt = item.PagoLocExt;
                    dat.PaisPago = item.PaisPago;
                    dat.ConvenioTributacion = item.ConvenioTributacion;
                    dat.PagoSujetoRetencion = item.PagoSujetoRetencion;
                    dat.Saldo = item.Saldo;
                    dat.IdTipoNota = item.IdTipoNota;
                    dat.cn_num_doc_modificado = item.cn_num_doc_modificado;
                    dat.cn_Autorizacion_Imprenta = item.cn_Autorizacion_Imprenta;
                    dat.Num_Nota = "NT" + item.DebCre + "#:" + item.cn_serie1 + "-" + item.cn_serie2 + "-" + item.cn_Nota; 
                    dat.fecha_autorizacion = Convert.ToDateTime(item.fecha_autorizacion);

                    dat.cn_Fecha_vcto = item.cn_Fecha_vcto;
                    dat.Fecha_contable = item.Fecha_contable;
                    dat.InfoProveedor.pr_nombre = item.pr_nombre;
                    dat.cod_nota = item.cod_nota;


                    lM.Add(dat);
                }
                return (lM);
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

        public List<cp_nota_DebCre_Info> Get_List_nota_DebCre(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, string DebCre)
        {
            try
            {
                try
                {
                    FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                    FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                    List<cp_nota_DebCre_Info> lM = new List<cp_nota_DebCre_Info>();
                    EntitiesCuentasxPagar Base = new EntitiesCuentasxPagar();

      

                    var select_ = (from T in Base.vwcp_nota_DebCre
                                   where T.IdEmpresa == IdEmpresa
                                     && T.cn_fecha <= FechaFin
                                     && T.cn_fecha >= FechaIni
                                     && T.DebCre == DebCre
                                   select T
                                  );

                    foreach (var item in select_)
                    {
                        cp_nota_DebCre_Info dat = new cp_nota_DebCre_Info();

                        dat.IdEmpresa = item.IdEmpresa;
                        dat.IdCbteCble_Nota = item.IdCbteCble_Nota;
                        dat.IdTipoCbte_Nota = item.IdTipoCbte_Nota;
                        dat.IdProveedor = item.IdProveedor;
                        dat.cn_fecha = item.cn_fecha;
                        dat.cn_serie1 = item.cn_serie1;
                        dat.cn_serie2 = item.cn_serie2;
                        dat.cn_Nota = item.cn_Nota;
                        dat.Fecha_contable = item.Fecha_contable;
                        dat.cn_observacion = item.cn_observacion;
                        dat.cn_subtotal_iva = item.cn_subtotal_iva;
                        dat.cn_subtotal_siniva = item.cn_subtotal_siniva;
                        dat.cn_baseImponible = item.cn_baseImponible;
                        dat.cn_Por_iva = item.cn_Por_iva;
                        dat.cn_valoriva = item.cn_valoriva;
                        dat.IdCod_ICE = item.IdCod_ICE;
                        dat.cn_Ice_base = item.cn_Ice_base;
                        dat.cn_Ice_por = item.cn_Ice_por;
                        dat.cn_Ice_valor = item.cn_Ice_valor;
                        dat.cn_Serv_por = item.cn_Serv_por;
                        dat.cn_Serv_valor = item.cn_Serv_valor;
                        dat.cn_BaseSeguro = item.cn_BaseSeguro;
                        dat.cn_total = item.cn_total;
                        dat.cn_vaCoa = item.cn_vaCoa;
                        dat.cn_Autorizacion = item.cn_Autorizacion;
                        dat.IdTipoServicio = item.IdTipoServicio;
                        dat.IdCtaCble_Acre = item.IdCtaCble_Acre;
                        dat.IdCtaCble_IVA = item.IdCtaCble_IVA;
                        dat.IdUsuario = item.IdUsuario;
                        dat.Fecha_Transac = item.Fecha_Transac;
                        dat.Estado = item.Estado;
                        dat.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        dat.Fecha_UltMod = item.Fecha_UltMod;
                        dat.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        dat.MotivoAnu = item.MotivoAnu;
                        dat.nom_pc = item.nom_pc;
                        dat.ip = item.ip;
                        dat.Fecha_UltAnu = item.Fecha_UltAnu;
                        dat.IdCbteCble_Anulacion = item.IdCbteCble_Anulacion;
                        dat.IdTipoCbte_Anulacion = item.IdTipoCbte_Anulacion;
                        dat.nomProveedor = item.pr_nombre;
                        dat.cn_tipoLocacion = item.cn_tipoLocacion;
                        dat.IdCentroCosto = item.IdCentroCosto;
                        dat.IdSucursal = item.IdSucursal;
                        dat.IdTipoFlujo = item.IdTipoFlujo;
                        dat.DebCre = (item.DebCre == "C") ? "Credito" : "Debito";
                        dat.IdIden_credito = item.IdIden_credito;
                        dat.PagoLocExt = item.PagoLocExt;
                        dat.PaisPago = item.PaisPago;
                        dat.ConvenioTributacion = item.ConvenioTributacion;
                        dat.PagoSujetoRetencion = item.PagoSujetoRetencion;
                        dat.Saldo = item.Saldo;
                        dat.IdTipoNota = item.IdTipoNota;
                        dat.cn_num_doc_modificado = item.cn_num_doc_modificado;
                        dat.cn_Autorizacion_Imprenta = item.cn_Autorizacion_Imprenta;
                        dat.fecha_autorizacion = Convert.ToDateTime(item.fecha_autorizacion);
                        dat.Num_Nota = "NT" + item.DebCre + "#:" + item.cn_serie1 + "-" + item.cn_serie2 + "-" + item.cn_Nota;
                        dat.cn_Fecha_vcto = item.cn_Fecha_vcto;
                        dat.Fecha_contable = item.Fecha_contable;
                        dat.cod_nota = item.cod_nota;
                        dat.InfoProveedor.pr_nombre = item.pr_nombre;

                        dat.InfoProveedor.IdClaseProveedor = item.IdClaseProveedor;
                        dat.InfoProveedor.descripcion_clas_prove = item.descripcion_clas_prove;


                        lM.Add(dat);
                    }
                    return (lM);
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.ToString() + " " + ex.Message;
                    mensaje = "Error al Grabar" + ex.Message;
                    throw new Exception(ex.ToString());
                }
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
        
        public Boolean GrabarDB(cp_nota_DebCre_Info info,ref string mensaje)
        {
            try
            {
                try
                {
                    using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                    {
                        EntitiesCuentasxPagar EDB = new EntitiesCuentasxPagar();



                        var Q = from per in EDB.cp_nota_DebCre
                                where per.IdEmpresa == info.IdEmpresa
                                && per.IdCbteCble_Nota == info.IdCbteCble_Nota
                                && per.IdTipoCbte_Nota == info.IdTipoCbte_Nota
                                select per;

                        if (Q.ToList().Count == 0)
                        {

                            cp_nota_DebCre address = new cp_nota_DebCre();

                            address.IdEmpresa = info.IdEmpresa;
                            address.IdCbteCble_Nota = info.IdCbteCble_Nota;
                            address.IdTipoCbte_Nota = info.IdTipoCbte_Nota;
                            address.IdProveedor = info.IdProveedor;
                            address.cn_fecha = Convert.ToDateTime(info.cn_fecha.ToShortDateString());
                            address.cn_serie1 = info.cn_serie1;
                            address.cn_serie2 = info.cn_serie2;
                            address.cn_Nota = info.cn_Nota;
                            address.cn_observacion = info.cn_observacion;
                            address.cn_subtotal_iva = info.cn_subtotal_iva;
                            address.cn_subtotal_siniva = info.cn_subtotal_siniva;
                            address.cn_baseImponible = info.cn_baseImponible;
                            address.cn_Por_iva = info.cn_Por_iva;
                            address.cn_valoriva = info.cn_valoriva;
                            address.IdCod_ICE = (info.IdCod_ICE == 0) ? null : info.IdCod_ICE;
                            address.cn_Ice_base = info.cn_Ice_base;
                            address.cn_Ice_por = info.cn_Ice_por;
                            address.cn_Ice_valor = info.cn_Ice_valor;
                            address.cn_Serv_por = info.cn_Serv_por;
                            address.cn_Serv_valor = info.cn_Serv_valor;
                            address.cn_BaseSeguro = info.cn_BaseSeguro;
                            address.cn_total = info.cn_total;
                            address.cn_vaCoa = (info.cn_vaCoa == null) ? "N" : info.cn_vaCoa;
                            address.cn_Autorizacion = info.cn_Autorizacion;
                            address.IdTipoServicio = (info.IdTipoServicio == "") ? null : info.IdTipoServicio;
                            address.IdCtaCble_Acre = info.IdCtaCble_Acre;
                            address.IdCtaCble_IVA = info.IdCtaCble_IVA;
                            address.IdUsuario = (info.IdUsuario == null) ? "" : info.IdUsuario;
                            address.Fecha_Transac = DateTime.Now;
                            address.Estado = info.Estado;
                            address.IdUsuarioUltMod = (info.IdUsuario == null) ? "" : info.IdUsuarioUltMod;
                            address.Fecha_UltMod = info.Fecha_UltMod;
                            address.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                            address.MotivoAnu = info.MotivoAnu;
                            address.nom_pc = (info.nom_pc == null) ? "" : info.nom_pc;
                            address.ip = (info.ip == null) ? "" : info.ip;
                            address.Fecha_UltAnu = info.Fecha_UltAnu;
                            address.IdCbteCble_Anulacion = info.IdCbteCble_Anulacion;
                            address.IdTipoCbte_Anulacion = info.IdTipoCbte_Anulacion;
                            address.cn_tipoLocacion = info.cn_tipoLocacion;
                            address.IdIden_credito = info.IdIden_credito;
                            address.IdCentroCosto = info.IdCentroCosto;
                            address.IdSucursal = Convert.ToInt32(info.IdSucursal);
                            address.IdTipoFlujo = info.IdTipoFlujo;
                            address.DebCre = info.DebCre;
                            address.cn_Fecha_vcto = Convert.ToDateTime(info.cn_Fecha_vcto.Value.ToShortDateString());
                            address.Fecha_contable = Convert.ToDateTime(info.Fecha_contable.Value.ToShortDateString());
                            address.PagoLocExt = info.PagoLocExt;
                            address.PaisPago = info.PaisPago;
                            address.ConvenioTributacion = info.ConvenioTributacion;
                            address.PagoSujetoRetencion = info.PagoSujetoRetencion;
                            address.IdTipoNota = info.IdTipoNota;
                            address.cn_Autorizacion_Imprenta = info.cn_Autorizacion_Imprenta;
                            address.cn_num_doc_modificado = info.cn_num_doc_modificado;
                            address.cod_nota = info.cod_nota==null || info.cod_nota=="" ? info.IdCbteCble_Nota.ToString() : info.cod_nota;


                            address.fecha_autorizacion = info.fecha_autorizacion;

                            context.cp_nota_DebCre.Add(address);
                            context.SaveChanges();
                        }
                        else
                        {
                            mensaje = "No se grabo a nota";
                            return false;
                        }

                    }
                    return true;
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.ToString() + " " + ex.Message;
                    mensaje = "Error al Grabar" + ex.Message;
                    throw new Exception(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje ="No se grabo a nota" + " " + ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        
        public Boolean ModificarDB(cp_nota_DebCre_Info info)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {

                    var contact = context.cp_nota_DebCre.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdCbteCble_Nota == info.IdCbteCble_Nota && minfo.IdTipoCbte_Nota == info.IdTipoCbte_Nota);
                    if (contact != null)
                    {
                        contact.IdProveedor = info.IdProveedor;
                        //contact.cp_codigo_SRI=info.c
                        contact.cn_fecha = info.cn_fecha;
                        contact.cn_serie1 = info.cn_serie1;
                        contact.cn_serie2 = info.cn_serie2;
                        contact.cn_Nota = info.cn_Nota;
                        contact.Fecha_contable = info.Fecha_contable;
                        contact.cn_observacion = info.cn_observacion;
                        contact.cn_subtotal_iva = info.cn_subtotal_iva;
                        contact.cn_subtotal_siniva = info.cn_subtotal_siniva;
                        contact.cn_baseImponible = info.cn_baseImponible;
                        contact.cn_Por_iva = info.cn_Por_iva;
                        contact.cn_valoriva = info.cn_valoriva;
                        contact.IdCod_ICE = (info.IdCod_ICE == 0) ? null : info.IdCod_ICE;
                        contact.cn_Ice_base = info.cn_Ice_base;
                        contact.cn_Ice_por = info.cn_Ice_por;
                        contact.cn_Ice_valor = info.cn_Ice_valor;
                        contact.cn_Serv_por = info.cn_Serv_por;
                        contact.cn_Serv_valor = info.cn_Serv_valor;
                        contact.cn_BaseSeguro = info.cn_BaseSeguro;
                        contact.cn_total = info.cn_total;
                        contact.cn_vaCoa = info.cn_vaCoa;
                        contact.cn_Autorizacion = info.cn_Autorizacion;
                        contact.IdTipoServicio = (info.IdTipoServicio == "") ? null : info.IdTipoServicio;
                        contact.IdCtaCble_Acre = info.IdCtaCble_Acre;
                        contact.IdCtaCble_IVA = info.IdCtaCble_IVA;
                        contact.Estado = info.Estado;
                        contact.cn_tipoLocacion = info.cn_tipoLocacion;
                        contact.Fecha_UltMod = info.Fecha_UltMod;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.IdCentroCosto = info.IdCentroCosto;
                        contact.IdSucursal = Convert.ToInt32(info.IdSucursal);
                        contact.IdTipoFlujo = info.IdTipoFlujo;
                        contact.DebCre = info.DebCre;
                        contact.IdIden_credito = (info.IdIden_credito == 0) ? null : info.IdIden_credito;
                        contact.IdTipoNota = info.IdTipoNota;
                        contact.PagoLocExt = info.PagoLocExt;
                        contact.PaisPago = info.PaisPago;
                        contact.ConvenioTributacion = info.ConvenioTributacion;
                        contact.PagoSujetoRetencion = info.PagoSujetoRetencion;
                        contact.cn_num_doc_modificado = info.cn_num_doc_modificado;
                        contact.cn_Autorizacion_Imprenta = info.cn_Autorizacion_Imprenta;
                        contact.fecha_autorizacion = info.fecha_autorizacion;
                        contact.cn_Fecha_vcto =(DateTime) info.cn_Fecha_vcto;
                        contact.Fecha_contable = info.Fecha_contable;
                        contact.cod_nota = info.cod_nota;
                        context.SaveChanges();
                    }
                }
                return true;
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
        
        public Boolean AnularDB(cp_nota_DebCre_Info info)
        {
            try
            {
                using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                {
                    var contact = context.cp_nota_DebCre.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdCbteCble_Nota == info.IdCbteCble_Nota && minfo.IdTipoCbte_Nota == info.IdTipoCbte_Nota);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.cn_observacion = "**ANULADO** " + contact.cn_observacion;
                        contact.MotivoAnu = info.MotivoAnu;
                        contact.Fecha_UltAnu = info.Fecha_UltAnu;
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        //contact.IdCbteCble_Anulacion = info.IdCbteCble_Anulacion;
                        //contact.IdTipoCbte_Anulacion = info.IdTipoCbte_Anulacion;
                        contact.cn_tipoLocacion = info.cn_tipoLocacion;
                        context.SaveChanges();
                    }
                }
                return true;
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

        public Boolean VericarNumDocumento(int IdEmpresa, decimal IdProveedor, string Serie1, string Serie2,  string cn_NotaC, decimal IdCbteCble_NotaC, int IdTipoCbte_NotaC, ref string mensaje)
        {
            try
            {
                Boolean Existe;
                    string scodigo;
                    scodigo = cn_NotaC.Trim();
                    mensaje = "";
                    Existe = false;

                    EntitiesCuentasxPagar B = new EntitiesCuentasxPagar();

                    var select_ = from t in B.cp_nota_DebCre
                                  where t.cn_Nota == scodigo 
                                  && t.IdEmpresa == IdEmpresa 
                                  && t.IdTipoCbte_Nota == IdTipoCbte_NotaC
                                  && t.cn_serie1==Serie1
                                  && t.cn_serie2 == Serie2
                                  && t.IdProveedor == IdProveedor
                                  select t;



                    foreach (var item in select_)
                    {
                        if (item.IdCbteCble_Nota != IdCbteCble_NotaC)
                        {
                            mensaje = mensaje + " " + item.IdCbteCble_Nota;
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        

        public Boolean Existe_NumNotaCredito_Proveedor(int IdEmpresa, decimal IdProveedor, String ptoEmision, String Establecimiento,String secuencial, String Tipo, String IdTipoNota)
        {
            try
            {
                using (EntitiesCuentasxPagar Entity = new EntitiesCuentasxPagar())
                {

                    if (!String.IsNullOrEmpty(ptoEmision) && !String.IsNullOrEmpty(Establecimiento) && !String.IsNullOrEmpty(secuencial))
                    {


                        ptoEmision = ptoEmision.Trim();
                        Establecimiento = Establecimiento.Trim();
                        secuencial = secuencial.Trim();
                        var result = from q in Entity.cp_nota_DebCre
                                     where q.IdEmpresa == IdEmpresa 
                                     && q.IdProveedor == IdProveedor 
                                     && q.cn_serie1 == ptoEmision
                                     && q.cn_serie2 == Establecimiento 
                                     && q.cn_Nota == secuencial 
                                     && q.DebCre == Tipo
                                     && q.IdTipoNota == IdTipoNota
                                     select q;

                        if (result.Count() != 0)
                        {
                            return true;
                        }
                        else
                        { return false; }
                    }
                    else
                    {

                        return false;
                    }
                                   
                }
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


        public cp_nota_DebCre_Info Get_Info_nota_DebCre(int IdEmpresa, decimal IdCbteCble_NotaC, int IdTipoCbte_NotaC)
        {
            try
            {
                cp_nota_DebCre_Info lM = new cp_nota_DebCre_Info();
                EntitiesCuentasxPagar Base = new EntitiesCuentasxPagar();

                var select_ = (from T in Base.cp_nota_DebCre
                               join P in Base.cp_proveedor on new { T.IdProveedor, T.IdEmpresa } equals new { P.IdProveedor, P.IdEmpresa }
                               where T.IdEmpresa == IdEmpresa && T.IdCbteCble_Nota == IdCbteCble_NotaC && T.IdTipoCbte_Nota == IdTipoCbte_NotaC
                               select new
                               {
                                   T.IdEmpresa,
                                   T.IdCbteCble_Nota,
                                   T.IdTipoCbte_Nota,
                                   T.IdProveedor,
                                   T.cn_fecha,
                                   T.cn_serie1,
                                   T.cn_serie2,
                                   T.cn_Nota,
                                   T.Fecha_contable,
                                   T.cn_observacion,
                                   T.cn_subtotal_iva,
                                   T.cn_subtotal_siniva,
                                   T.cn_baseImponible,
                                   T.cn_Por_iva,
                                   T.cn_valoriva,
                                   T.IdCod_ICE,
                                   T.cn_Ice_base,
                                   T.cn_Ice_por,
                                   T.cn_Ice_valor,
                                   T.cn_Serv_por,
                                   T.cn_Serv_valor,
                                   T.cn_BaseSeguro,
                                   T.cn_total,
                                   T.cn_vaCoa,
                                   T.cn_Autorizacion,
                                   T.IdTipoServicio,
                                   T.IdCtaCble_Acre,
                                   T.IdCtaCble_IVA,
                                   T.IdUsuario,
                                   T.Fecha_Transac,
                                   T.Estado,
                                   T.IdUsuarioUltMod,
                                   T.Fecha_UltMod,
                                   T.IdUsuarioUltAnu,
                                   T.MotivoAnu,
                                   T.nom_pc,
                                   T.ip,
                                   T.Fecha_UltAnu,
                                   T.IdCbteCble_Anulacion,
                                   T.IdTipoCbte_Anulacion,
                                   P.pr_nombre,
                                   T.cn_tipoLocacion,
                                   T.IdCentroCosto,
                                   T.IdSucursal,
                                   T.IdTipoFlujo,
                                   T.DebCre,
                                   T.IdIden_credito,
                                   T.PagoLocExt,
                                   T.PaisPago,
                                   T.ConvenioTributacion,
                                   T.PagoSujetoRetencion,
                                   T.IdTipoNota,
                                   T.cn_num_doc_modificado,
                                   T.cn_Autorizacion_Imprenta,
                                   T.fecha_autorizacion,
                                   T.cn_Fecha_vcto,
                                   T.cod_nota
                               }
                              );

                foreach (var item in select_)
                {
                    cp_nota_DebCre_Info dat = new cp_nota_DebCre_Info();

                    dat.IdEmpresa = item.IdEmpresa;
                    dat.IdCbteCble_Nota = item.IdCbteCble_Nota;
                    dat.IdTipoCbte_Nota = item.IdTipoCbte_Nota;
                    dat.IdProveedor = item.IdProveedor;
                    dat.cn_fecha = item.cn_fecha;
                    dat.cn_serie1 = item.cn_serie1;
                    dat.cn_serie2 = item.cn_serie2;
                    dat.cn_Nota = item.cn_Nota;
                    dat.cn_NotaRpt = item.cn_Nota;
                    dat.Fecha_contable = item.Fecha_contable;
                    dat.cn_observacion = item.cn_observacion;
                    dat.cn_subtotal_iva = item.cn_subtotal_iva;
                    dat.cn_subtotal_siniva = item.cn_subtotal_siniva;
                    dat.cn_baseImponible = item.cn_baseImponible;
                    dat.cn_Por_iva = item.cn_Por_iva;
                    dat.cn_valoriva = item.cn_valoriva;
                    dat.IdCod_ICE = item.IdCod_ICE;
                    dat.cn_Ice_base = item.cn_Ice_base;
                    dat.cn_Ice_por = item.cn_Ice_por;
                    dat.cn_Ice_valor = item.cn_Ice_valor;
                    dat.cn_Serv_por = item.cn_Serv_por;
                    dat.cn_Serv_valor = item.cn_Serv_valor;
                    dat.cn_BaseSeguro = item.cn_BaseSeguro;
                    dat.cn_total = item.cn_total;
                    dat.cn_vaCoa = item.cn_vaCoa;
                    dat.cn_Autorizacion = item.cn_Autorizacion;
                    dat.IdTipoServicio = item.IdTipoServicio;
                    dat.IdCtaCble_Acre = item.IdCtaCble_Acre;
                    dat.IdCtaCble_IVA = item.IdCtaCble_IVA;
                    dat.IdUsuario = item.IdUsuario;
                    dat.Fecha_Transac = item.Fecha_Transac;
                    dat.Estado = item.Estado;
                    dat.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    dat.Fecha_UltMod = item.Fecha_UltMod;
                    dat.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    dat.MotivoAnu = item.MotivoAnu;
                    dat.nom_pc = item.nom_pc;
                    dat.ip = item.ip;
                    dat.Fecha_UltAnu = item.Fecha_UltAnu;
                    dat.IdCbteCble_Anulacion = item.IdCbteCble_Anulacion;
                    dat.IdTipoCbte_Anulacion = item.IdTipoCbte_Anulacion;
                    dat.nomProveedor = item.pr_nombre;
                    dat.cn_tipoLocacion = item.cn_tipoLocacion;
                    dat.IdCentroCosto = item.IdCentroCosto;
                    dat.IdSucursal = item.IdSucursal;
                    dat.IdTipoFlujo = item.IdTipoFlujo;
                    dat.DebCre = item.DebCre;
                    dat.IdIden_credito = item.IdIden_credito;
                    dat.PagoLocExt = item.PagoLocExt;
                    dat.PaisPago = item.PaisPago;
                    dat.ConvenioTributacion = item.ConvenioTributacion;
                    dat.PagoSujetoRetencion = item.PagoSujetoRetencion;
                    dat.IdTipoNota = item.IdTipoNota;
                    dat.cn_num_doc_modificado = item.cn_num_doc_modificado;
                    dat.cn_Autorizacion_Imprenta = item.cn_Autorizacion_Imprenta;
                    dat.Num_Nota = "NT" + item.DebCre + "#:" + item.cn_serie1 + "-" + item.cn_serie2 + "-" + item.cn_Nota; 
                    dat.fecha_autorizacion = Convert.ToDateTime(item.fecha_autorizacion);
                    dat.cn_Fecha_vcto = item.cn_Fecha_vcto;
                    dat.Fecha_contable = item.Fecha_contable;
                    dat.cod_nota = item.cod_nota;
                    dat.InfoProveedor.pr_nombre = item.pr_nombre;



                    lM = dat;
                }
                return (lM);
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

        public cp_rpt_nota_credito_Info Get_Info_rpt_nota_credito(int IdEmpresa, decimal IdProveedor, decimal IdCbteCble_NotaC, int IdTipoCbte_NotaC)
        {
            try
            {
                cp_rpt_nota_credito_Info Datos = new cp_rpt_nota_credito_Info();

                tb_Empresa_Data Empresa_D = new tb_Empresa_Data();
                cp_proveedor_Data Proveedor_D = new cp_proveedor_Data();
                cp_nota_DebCre_Data NotaCr_D = new cp_nota_DebCre_Data();
                //cp_orden_giro_pagos_Data PagosOG_D = new cp_orden_giro_pagos_Data();
                tb_persona_data Persona_D = new tb_persona_data();
                cp_proveedor_Info Proveedor_I = new cp_proveedor_Info();

                Proveedor_I = Proveedor_D.Get_Info_Proveedor(IdEmpresa, IdProveedor);
                Datos.Empresa = Empresa_D.Get_Info_Empresa(IdEmpresa);
                Datos.Proveedor = Proveedor_I;
                Datos.NotaCr = NotaCr_D.Get_Info_nota_DebCre(IdEmpresa, IdCbteCble_NotaC, IdTipoCbte_NotaC);
                
                Datos.Persona = Persona_D.Get_Info_Persona(Proveedor_I.IdPersona);
                return Datos;
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

        public cp_nota_DebCre_Data() { }

        public bool Modificar_tipo_flujo(cp_nota_DebCre_Info info_nota)
        {
            try
            {
                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    cp_nota_DebCre Entity = Context.cp_nota_DebCre.FirstOrDefault(q => q.IdEmpresa == info_nota.IdEmpresa && q.IdTipoCbte_Nota == info_nota.IdTipoCbte_Nota && q.IdCbteCble_Nota == info_nota.IdCbteCble_Nota);
                    if (Entity != null)
                    {
                        Entity.IdTipoFlujo = info_nota.IdTipoFlujo;
                        Context.SaveChanges();
                    }
                }

                return true;
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
    }
}
