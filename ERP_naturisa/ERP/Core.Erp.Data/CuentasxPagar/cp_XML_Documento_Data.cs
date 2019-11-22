using Core.Erp.Data.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_XML_Documento_Data
    {
        tb_sis_Documento_Tipo_Talonario_Data odataTalonario = new tb_sis_Documento_Tipo_Talonario_Data();

        public List<cp_XML_Documento_Info> GetList(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                FechaIni = FechaIni.Date;
                FechaFin = FechaFin.Date;

                List<cp_XML_Documento_Info> Lista = new List<cp_XML_Documento_Info>();

                using (EntitiesCuentasxPagar db = new EntitiesCuentasxPagar())
                {
                    var lst = db.cp_XML_Documento.Where(q => q.IdEmpresa == IdEmpresa && FechaIni <= q.FechaEmision && q.FechaEmision <= FechaFin).ToList();
                    foreach (var info in lst)
                    {
                        Lista.Add(new cp_XML_Documento_Info
                    {
                        IdEmpresa = info.IdEmpresa,
                        IdDocumento = info.IdDocumento,
                        XML = info.XML,
                        Tipo = info.Tipo,
                        emi_RazonSocial = info.emi_RazonSocial,
                        emi_NombreComercial = info.emi_NombreComercial,
                        emi_Ruc = info.emi_Ruc,
                        emi_DireccionMatriz = info.emi_DireccionMatriz,
                        ClaveAcceso = info.ClaveAcceso,
                        CodDocumento = info.CodDocumento,
                        Establecimiento = info.Establecimiento,
                        PuntoEmision = info.PuntoEmision,
                        NumeroDocumento = info.NumeroDocumento,
                        FechaEmision = info.FechaEmision,
                        rec_RazonSocial = info.rec_RazonSocial,
                        rec_Identificacion = info.rec_Identificacion,
                        Subtotal0 = info.Subtotal0,
                        SubtotalIVA = info.SubtotalIVA,
                        Porcentaje = info.Porcentaje,
                        ValorIVA = info.ValorIVA,
                        Total = info.Total,
                        FormaPago = info.FormaPago,
                        Plazo = info.Plazo,
                        Comprobante = info.Comprobante,
                        Estado = info.Estado,

                        ret_CodDocumentoTipo = info.ret_CodDocumentoTipo,
                        ret_Establecimiento = info.ret_Establecimiento,
                        ret_Fecha = info.ret_Fecha,
                        ret_FechaAutorizacion = info.ret_FechaAutorizacion,
                        ret_NumeroAutorizacion = info.ret_NumeroAutorizacion,
                        ret_NumeroDocumento = info.ret_NumeroDocumento,
                        ret_PuntoEmision = info.ret_PuntoEmision
                    });
                    }
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public List<cp_XML_Documento_Info> GetList(int IdEmpresa, string pe_cedulaRuc)
        {
            try
            {
                List<cp_XML_Documento_Info> Lista = new List<cp_XML_Documento_Info>();
                List<cp_XML_Documento> lst = new List<cp_XML_Documento>();
                using (EntitiesCuentasxPagar db = new EntitiesCuentasxPagar())
                {
                    if(string.IsNullOrEmpty(pe_cedulaRuc))
                        lst = db.cp_XML_Documento.Where(q => q.IdEmpresa == IdEmpresa && q.Estado == true && q.IdCbteCble == null).ToList();
                    else
                        lst = db.cp_XML_Documento.Where(q => q.IdEmpresa == IdEmpresa && q.Estado == true && q.IdCbteCble == null && q.emi_Ruc == pe_cedulaRuc).ToList();

                    foreach (var info in lst)
                    {
                        Lista.Add(new cp_XML_Documento_Info
                        {
                            IdEmpresa = info.IdEmpresa,
                            IdDocumento = info.IdDocumento,
                            XML = info.XML,
                            Tipo = info.Tipo,
                            emi_RazonSocial = info.emi_RazonSocial,
                            emi_NombreComercial = info.emi_NombreComercial,
                            emi_Ruc = info.emi_Ruc,
                            emi_DireccionMatriz = info.emi_DireccionMatriz,
                            ClaveAcceso = info.ClaveAcceso,
                            CodDocumento = info.CodDocumento,
                            Establecimiento = info.Establecimiento,
                            PuntoEmision = info.PuntoEmision,
                            NumeroDocumento = info.NumeroDocumento,
                            FechaEmision = info.FechaEmision,
                            rec_RazonSocial = info.rec_RazonSocial,
                            rec_Identificacion = info.rec_Identificacion,
                            Subtotal0 = info.Subtotal0,
                            SubtotalIVA = info.SubtotalIVA,
                            Porcentaje = info.Porcentaje,
                            ValorIVA = info.ValorIVA,
                            Total = info.Total,
                            FormaPago = info.FormaPago,
                            Plazo = info.Plazo,
                            Comprobante = info.Comprobante,
                            Estado = info.Estado,

                            ret_CodDocumentoTipo = info.ret_CodDocumentoTipo,
                            ret_Establecimiento = info.ret_Establecimiento,
                            ret_Fecha = info.ret_Fecha,
                            ret_FechaAutorizacion = info.ret_FechaAutorizacion,
                            ret_NumeroAutorizacion = info.ret_NumeroAutorizacion,
                            ret_NumeroDocumento = info.ret_NumeroDocumento,
                            ret_PuntoEmision = info.ret_PuntoEmision
                        });
                    }
                }

                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool GuardarDB(cp_XML_Documento_Info info)
        {
            try
            {
                if (Existe(info.IdEmpresa, info.emi_Ruc, info.CodDocumento, info.Establecimiento, info.PuntoEmision, info.NumeroDocumento) == 2)
                    return true;

                if (info.lstRetencion.Count > 0)
                {
                    info.ret_CodDocumentoTipo = info.ret_CodDocumentoTipo = "RETEN";
                    var talonario = odataTalonario.GetDocumentoElectronicoUpdateUsado(info.IdEmpresa, info.ret_CodDocumentoTipo, info.ret_Establecimiento, info.ret_PuntoEmision);
                    if (talonario == null)
                    {
                        return false;
                    }
                    info.ret_NumeroDocumento = talonario.NumDocumento;                    
                    info.ret_Establecimiento = info.ret_Establecimiento;
                    info.ret_PuntoEmision = info.ret_PuntoEmision;
                    info.ret_NumeroDocumento = info.ret_NumeroDocumento;
                    info.ret_Fecha = info.FechaEmision;
                }

                using (EntitiesCuentasxPagar db = new EntitiesCuentasxPagar())
                {
                    db.cp_XML_Documento.Add(new cp_XML_Documento
                    {
                        IdEmpresa = info.IdEmpresa,
                        IdDocumento = info.IdDocumento = GetID(info.IdEmpresa),
                        XML = info.XML,
                        Tipo = info.Tipo,
                        emi_RazonSocial = info.emi_RazonSocial,
                        emi_NombreComercial = info.emi_NombreComercial,
                        emi_Ruc = info.emi_Ruc,
                        emi_DireccionMatriz = info.emi_DireccionMatriz,
                        ClaveAcceso = info.ClaveAcceso,
                        CodDocumento = info.CodDocumento,
                        Establecimiento = info.Establecimiento,
                        PuntoEmision = info.PuntoEmision,
                        NumeroDocumento = info.NumeroDocumento,
                        FechaEmision = info.FechaEmision,
                        rec_RazonSocial = info.rec_RazonSocial,
                        rec_Identificacion = info.rec_Identificacion,
                        Subtotal0 = info.Subtotal0,
                        SubtotalIVA = info.SubtotalIVA,
                        Porcentaje = info.Porcentaje,
                        ValorIVA = info.ValorIVA,
                        Total = info.Total,
                        FormaPago = info.FormaPago,
                        Plazo = info.Plazo,
                        Comprobante = info.Comprobante,
                        Estado = true,

                        ret_CodDocumentoTipo = info.ret_CodDocumentoTipo,
                        ret_Establecimiento = info.ret_Establecimiento,
                        ret_Fecha = info.ret_Fecha,
                        ret_PuntoEmision = info.ret_PuntoEmision,
                        ret_NumeroDocumento = info.ret_NumeroDocumento
                    });

                    if (info.lstRetencion.Count > 0)
                    {
                        int Secuencia = 1;
                        foreach (var item in info.lstRetencion)
                        {
                            db.cp_XML_Documento_Retencion.Add(new cp_XML_Documento_Retencion
                            {
                                IdEmpresa = info.IdEmpresa,
                                IdDocumento = info.IdDocumento,
                                Secuencia = Secuencia++,
                                IdCodigo_SRI = item.IdCodigo_SRI,
                                re_baseRetencion = item.re_baseRetencion,
                                re_tipoRet = item.re_tipoRet,
                                re_valor_retencion = item.re_valor_retencion,
                                re_Codigo_impuesto = item.re_Codigo_impuesto,
                                re_Porcen_retencion = item.re_Porcen_retencion
                            });
                        }    
                    }
                    
                    info.Imagen = 2;
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ModificarDB(cp_XML_Documento_Info info)
        {
            try
            {
                using (EntitiesCuentasxPagar db = new EntitiesCuentasxPagar())
                {
                    var documento = db.cp_XML_Documento.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdDocumento == info.IdDocumento).FirstOrDefault();
                    if (documento == null)
                        return false;
                    if (string.IsNullOrEmpty(info.ret_NumeroDocumento))
                    {
                        var talonario = odataTalonario.GetDocumentoElectronicoUpdateUsado(info.IdEmpresa, info.ret_CodDocumentoTipo, info.ret_Establecimiento, info.ret_PuntoEmision);
                        if (talonario == null)
                        {
                            return false;
                        }
                        info.ret_NumeroDocumento = talonario.NumDocumento;
                    }

                    documento.ret_CodDocumentoTipo = info.ret_CodDocumentoTipo;
                    documento.ret_Establecimiento = info.ret_Establecimiento;
                    documento.ret_PuntoEmision = info.ret_PuntoEmision;
                    documento.ret_NumeroDocumento = info.ret_NumeroDocumento;
                    documento.ret_Fecha = info.ret_Fecha;

                    //documento.ret_NumeroAutorizacion = info.ret_NumeroAutorizacion;                    
                    //documento.ret_FechaAutorizacion = info.ret_FechaAutorizacion;

                    var lista = db.cp_XML_Documento_Retencion.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdDocumento == info.IdDocumento).ToList();
                    foreach (var item in lista)
                    {
                        db.cp_XML_Documento_Retencion.Remove(item);
                    }
                    int Secuencia = 1;
                    foreach (var item in info.lstRetencion)
                    {
                        db.cp_XML_Documento_Retencion.Add(new cp_XML_Documento_Retencion
                        {
                            IdEmpresa = info.IdEmpresa,
                            IdDocumento = info.IdDocumento,
                            Secuencia = Secuencia++,
                            IdCodigo_SRI = item.IdCodigo_SRI,
                            re_baseRetencion = item.re_baseRetencion,
                            re_tipoRet = item.re_tipoRet,
                            re_valor_retencion = item.re_valor_retencion,
                            re_Codigo_impuesto = item.re_Codigo_impuesto,
                            re_Porcen_retencion = item.re_Porcen_retencion
                        });
                    }

                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool AnularDB(cp_XML_Documento_Info info)
        {
            try
            {
                using (EntitiesCuentasxPagar db = new EntitiesCuentasxPagar())
                {
                    var entity = db.cp_XML_Documento.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdDocumento == info.IdDocumento).FirstOrDefault();
                    if (entity == null)
                        return false;

                    entity.Estado = false;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public decimal GetID(int IdEmpresa)
        {
            try
            {
                decimal ID = 1;
                using (EntitiesCuentasxPagar db = new EntitiesCuentasxPagar())
                {
                    int cont = db.cp_XML_Documento.Where(q=> q.IdEmpresa == IdEmpresa).Count();
                    if (cont > 0)
                    {
                        ID = db.cp_XML_Documento.Where(q => q.IdEmpresa == IdEmpresa).Max(q => q.IdDocumento) + 1;
                    }
                }
                return ID;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int Existe(int IdEmpresa, string Ruc, string CodDocumento, string Establecimiento, string PuntoEmision, string secuencial)
        {
            try
            {
                int Retorno = 1;
                using (EntitiesCuentasxPagar db = new EntitiesCuentasxPagar())
                {
                    if(db.cp_XML_Documento.Where(q=> q.IdEmpresa == IdEmpresa && q.emi_Ruc == Ruc && q.CodDocumento == CodDocumento && q.Establecimiento == Establecimiento && q.PuntoEmision == PuntoEmision && q.NumeroDocumento == secuencial).Count() > 0)
                        Retorno = 2;   
                }
                return Retorno;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<cp_XML_Documento_Info> Get_list_Retencion_Sri(int IdEmpresa, decimal IdDocumento)
        {
            try
            {
                List<cp_XML_Documento_Info> lista = new List<cp_XML_Documento_Info>();

                EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();


                var consulta = ECXP.vwcp_XML_Documento.Where(selec => selec.IdEmpresa == IdEmpresa
                                      && selec.IdDocumento == IdDocumento).ToList();


                foreach (var item in consulta)
                {
                    cp_XML_Documento_Info info = new cp_XML_Documento_Info
                    {
                        IdEmpresa = item.IdEmpresa,
                        IdDocumento = item.IdDocumento,
                        serie = item.serie,
                        ret_NumeroDocumento = item.ret_NumeroDocumento,
                        ret_Fecha = item.ret_Fecha,
                        pe_nombreCompleto = item.pe_nombreCompleto.Trim(),
                        emi_RazonSocial = (item.RazonSocial == null) ? "" : item.RazonSocial.Trim(),
                        emi_Ruc = item.emi_Ruc,
                        pe_correo = (item.pe_correo == null) ? "" : item.pe_correo.Trim(),
                        IdProveedor = item.IdProveedor,
                        FechaEmision = item.FechaEmision,
                        pe_direccion = (item.pe_direccion == null) ? "" : item.pe_direccion.Trim(),
                        pe_telfono_Contacto = (item.pe_telfono_Contacto == null) ? "" : item.pe_telfono_Contacto.Trim(),
                        co_serie = item.co_serie,
                        NumeroDocumento = item.NumeroDocumento,
                        CodDocumento = item.CodDocumento,
                        RazonSocial = item.RazonSocial.Trim(),
                        NombreComercial = (item.NombreComercial == null) ? "" : item.NombreComercial.Trim(),
                        ContribuyenteEspecial = item.ContribuyenteEspecial.Trim(),
                        ObligadoAllevarConta = item.ObligadoAllevarConta.Trim(),
                        em_ruc = item.em_ruc.Trim(),
                        em_direccion = (item.em_direccion == null) ? "" : item.em_direccion.Trim(),
                        IdTipoDocumento = item.IdTipoDocumento.Trim(),

                        IdSucursal = Convert.ToInt32(item.IdSucursal),
                        Su_Descripcion = item.Su_Descripcion.Trim(),
                        Su_Direccion = item.Su_Direccion.Trim(),
                        Estado = item.Estado,
                    };
                    lista.Add(info);
                }

                return lista;

            }
            catch (Exception)
            {
                throw;
            }

        }

        public cp_XML_Documento_Info GetInfo(int IdEmpresa, string CodDocumento, string pe_cedulaRuc, string Establecimiento, string PuntoEmision, string NumeroDocumento)
        {
            try
            {
                cp_XML_Documento_Info retorno = new cp_XML_Documento_Info();

                using (EntitiesCuentasxPagar db = new EntitiesCuentasxPagar())
                {
                    var info = db.cp_XML_Documento.Where(q => q.IdEmpresa == IdEmpresa && q.emi_Ruc == pe_cedulaRuc && q.CodDocumento == CodDocumento && q.Establecimiento == Establecimiento && q.PuntoEmision == PuntoEmision && q.NumeroDocumento == NumeroDocumento).FirstOrDefault();
                    if (info == null)
                        return null;

                    retorno = new cp_XML_Documento_Info
                    {
                        IdEmpresa = info.IdEmpresa,
                        IdDocumento = info.IdDocumento,
                        XML = info.XML,
                        Tipo = info.Tipo,
                        emi_RazonSocial = info.emi_RazonSocial,
                        emi_NombreComercial = info.emi_NombreComercial,
                        emi_Ruc = info.emi_Ruc,
                        emi_DireccionMatriz = info.emi_DireccionMatriz,
                        ClaveAcceso = info.ClaveAcceso,
                        CodDocumento = info.CodDocumento,
                        Establecimiento = info.Establecimiento,
                        PuntoEmision = info.PuntoEmision,
                        NumeroDocumento = info.NumeroDocumento,
                        FechaEmision = info.FechaEmision,
                        rec_RazonSocial = info.rec_RazonSocial,
                        rec_Identificacion = info.rec_Identificacion,
                        Subtotal0 = info.Subtotal0,
                        SubtotalIVA = info.SubtotalIVA,
                        Porcentaje = info.Porcentaje,
                        ValorIVA = info.ValorIVA,
                        Total = info.Total,
                        FormaPago = info.FormaPago,
                        Plazo = info.Plazo,
                        Comprobante = info.Comprobante,
                        Estado = info.Estado,

                        ret_CodDocumentoTipo = info.ret_CodDocumentoTipo,
                        ret_Establecimiento = info.ret_Establecimiento,
                        ret_Fecha = info.ret_Fecha,
                        ret_FechaAutorizacion = info.ret_FechaAutorizacion,
                        ret_NumeroAutorizacion = info.ret_NumeroAutorizacion,
                        ret_NumeroDocumento = info.ret_NumeroDocumento,
                        ret_PuntoEmision = info.ret_PuntoEmision
                    };
                }

                return retorno;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool ContabilizarDocumento(int IdEmpresa, decimal IdDocumento, int IdTipoCbte, decimal IdCbteCble, string IdCtaCbleProv, string IdUsuario, bool GenerarRetencion)
        {
            try
            {
                try
                {
                    using (EntitiesCuentasxPagar db = new EntitiesCuentasxPagar())
                    {
                        var Entity = db.cp_XML_Documento.Where(q => q.IdEmpresa == IdEmpresa && q.IdDocumento == IdDocumento).FirstOrDefault();
                        if (Entity == null)
                            return false;

                        Entity.IdTipoCbte = IdTipoCbte;
                        Entity.IdCbteCble = IdCbteCble;


                        if (GenerarRetencion && !string.IsNullOrEmpty(Entity.ret_NumeroDocumento))
                        {
                            var lst = db.cp_XML_Documento_Retencion.Where(q => q.IdEmpresa == IdEmpresa && q.IdDocumento == IdDocumento).ToList();
                            if (lst.Count != 0)
                            {
                                decimal IdRetencion = 0;
                                cp_retencion_Data odataR = new cp_retencion_Data();
                                db.cp_retencion.Add(new cp_retencion
                                {
                                    IdEmpresa = Entity.IdEmpresa,
                                    IdRetencion = IdRetencion = odataR.GetIdRetencion(Entity.IdEmpresa),
                                    CodDocumentoTipo = Entity.ret_CodDocumentoTipo,
                                    serie1 = Entity.ret_Establecimiento,
                                    serie2 = Entity.ret_PuntoEmision,
                                    NumRetencion = Entity.ret_NumeroDocumento,
                                    NAutorizacion = Entity.ret_NumeroAutorizacion,
                                    Fecha_Autorizacion = Entity.ret_FechaAutorizacion,
                                    fecha = Entity.ret_Fecha ?? DateTime.Now.Date,
                                    observacion = "Ret. x prove:" + Entity.emi_RazonSocial,
                                    re_Tiene_RFuente = lst.Where(q => q.re_tipoRet == "FTE").Count() > 0 ? "S" : "N",
                                    re_Tiene_RTiva = lst.Where(q => q.re_tipoRet == "IVA").Count() > 0 ? "S" : "N",
                                    IdEmpresa_Ogiro = Entity.IdEmpresa,
                                    IdTipoCbte_Ogiro = IdTipoCbte,
                                    IdCbteCble_Ogiro = IdCbteCble,
                                    re_EstaImpresa = "S",
                                    Estado = "A",
                                    IdUsuario = IdUsuario,
                                    Fecha_Transac = DateTime.Now
                                });

                                int Secuencia = 1;
                                foreach (var item in lst)
                                {
                                    db.cp_retencion_det.Add(new cp_retencion_det
                                    {
                                        IdEmpresa = Entity.IdEmpresa,
                                        IdRetencion = IdRetencion,
                                        Idsecuencia = Secuencia++,
                                        re_tipoRet = item.re_tipoRet,
                                        re_baseRetencion = item.re_baseRetencion,
                                        IdCodigo_SRI = item.IdCodigo_SRI,
                                        re_Codigo_impuesto = item.re_Codigo_impuesto,
                                        re_Porcen_retencion = item.re_Porcen_retencion,
                                        re_valor_retencion = item.re_valor_retencion,
                                        re_estado = "A",
                                        IdUsuario = IdUsuario,
                                        Fecha_Transac = DateTime.Now
                                    });
                                }
                                db.SaveChanges();
                                odataR.ContabilizarRetencion(Entity.IdEmpresa, IdRetencion, IdUsuario);
                            }
                        }
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
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
