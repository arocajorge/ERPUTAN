﻿using Core.Erp.Data.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_XML_Documento_Data
    {
        tb_sis_Documento_Tipo_Talonario_Data odataTalonario = new tb_sis_Documento_Tipo_Talonario_Data();
        cp_XML_DocumentoRetAnulado_Data odataAnulacion = new cp_XML_DocumentoRetAnulado_Data();
        cp_retencion_Data odataR = new cp_retencion_Data();

        public List<cp_XML_Documento_Info> GetList(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                FechaIni = FechaIni.Date;
                FechaFin = FechaFin.Date;

                List<cp_XML_Documento_Info> Lista = new List<cp_XML_Documento_Info>();

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();

                    string query = "SELECT        a.IdEmpresa, a.IdDocumento, a.ret_Establecimiento + '-' + a.ret_PuntoEmision AS serie, a.ret_NumeroDocumento, CASE WHEN datediff(day, a.ret_Fecha, CAST(getdate() AS date)) > 29 THEN CAST(getdate() AS date) "
                                +" ELSE a.ret_Fecha END AS ret_Fecha, a.emi_RazonSocial AS pe_nombreCompleto, a.emi_RazonSocial, a.emi_Ruc, per.pe_correo, per.pe_direccion, per.pe_telfono_Contacto, pro.IdProveedor, "
                                +" a.Establecimiento + '-' + a.PuntoEmision AS co_serie, a.NumeroDocumento, a.FechaEmision, a.CodDocumento, CASE WHEN LEN(A.emi_Ruc) = 10 THEN 'CED' WHEN LEN(A.emi_Ruc) "
                                +" = 13 THEN 'RUC' ELSE 'PAS' END AS IdTipoDocumento, su.IdSucursal, su.Su_Descripcion, su.Su_Direccion, em.RazonSocial, em.NombreComercial, em.ContribuyenteEspecial, em.ObligadoAllevarConta, em.em_ruc, "
                                +" em.em_direccion, a.Estado, CASE WHEN ISNULL(round(og.saldo, 2), A.Total) = 0 THEN 'CANCELADO' ELSE 'PENDIENTE' END AS EstadoCancelacion, a.Tipo, a.emi_NombreComercial, a.emi_DireccionMatriz, a.ClaveAcceso, "
                                +" a.Establecimiento, a.PuntoEmision, a.rec_RazonSocial, a.rec_Identificacion, a.Subtotal0, a.SubtotalIVA, a.Porcentaje, a.ValorIVA, a.Total, a.FormaPago, a.Plazo, a.Comprobante, a.emi_ContribuyenteEspecial, "
                                +" a.ret_CodDocumentoTipo, a.ret_Establecimiento, a.ret_FechaAutorizacion, a.ret_NumeroAutorizacion, a.ret_PuntoEmision, a.IdTipoCbte, a.IdCbteCble, cl.descripcion_clas_prove,"
                                + " CASE WHEN A.Estado = 1 and a.ret_NumeroDocumento IS NOT NULL AND A.ret_NumeroAutorizacion IS NULL then cast(1 as bit) else cast(0 as bit) END AS EnviaXML"
                                +" FROM            Digitalizacion.cp_XML_Documento AS a LEFT OUTER JOIN"
                                +" dbo.tb_persona AS per ON a.emi_Ruc = per.pe_cedulaRuc LEFT OUTER JOIN"
                                +" dbo.cp_proveedor AS pro ON per.IdPersona = pro.IdPersona AND a.IdEmpresa = pro.IdEmpresa INNER JOIN"
                                +" dbo.tb_sucursal AS su ON su.IdEmpresa = a.IdEmpresa AND su.IdSucursal = 1 INNER JOIN"
                                +" dbo.tb_empresa AS em ON em.IdEmpresa = a.IdEmpresa LEFT OUTER JOIN"
                                +" dbo.vwcp_orden_giro_consulta AS og ON a.IdEmpresa = og.IdEmpresa AND a.IdTipoCbte = og.IdTipoCbte_Ogiro AND a.IdCbteCble = og.IdCbteCble_Ogiro LEFT OUTER JOIN"
                                +" dbo.cp_proveedor_clase AS cl ON pro.IdEmpresa = cl.IdEmpresa AND pro.IdClaseProveedor = cl.IdClaseProveedor"
                                +" WHERE        (a.Estado = 1) AND (a.Tipo = 'FACTURA') and a.IdEmpresa = "+IdEmpresa.ToString()
                                + " and a.FechaEmision between DATEFROMPARTS(" + FechaIni.Year.ToString() + "," + FechaIni.Month.ToString() + "," + FechaIni.Day.ToString() + ") AND DATEFROMPARTS(" + FechaFin.Year.ToString() + "," + FechaFin.Month.ToString() + "," + FechaFin.Day.ToString() + ")";

                    SqlCommand Command = new SqlCommand(query,connection);
                    SqlDataReader reader = Command.ExecuteReader();
                    while (reader.Read())
                    {
                        Lista.Add(new cp_XML_Documento_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdDocumento = Convert.ToDecimal(reader["IdDocumento"]),
                            Tipo = Convert.ToString(reader["Tipo"]),
                            emi_RazonSocial = Convert.ToString(reader["emi_RazonSocial"]),
                            emi_NombreComercial = Convert.ToString(reader["emi_NombreComercial"]),
                            emi_Ruc = Convert.ToString(reader["emi_Ruc"]),
                            emi_DireccionMatriz = Convert.ToString(reader["emi_DireccionMatriz"]),                            ClaveAcceso = Convert.ToString(reader["ClaveAcceso"]),
                            CodDocumento = Convert.ToString(reader["CodDocumento"]),
                            Establecimiento = Convert.ToString(reader["Establecimiento"]),
                            PuntoEmision = Convert.ToString(reader["PuntoEmision"]),
                            NumeroDocumento = Convert.ToString(reader["NumeroDocumento"]),
                            FechaEmision = Convert.ToDateTime(reader["FechaEmision"]),
                            rec_RazonSocial = Convert.ToString(reader["rec_RazonSocial"]),
                            rec_Identificacion = Convert.ToString(reader["rec_Identificacion"]),
                            Subtotal0 = Convert.ToDouble(reader["Subtotal0"]),
                            SubtotalIVA = Convert.ToDouble(reader["SubtotalIVA"]),
                            Porcentaje = Convert.ToDouble(reader["Porcentaje"]),
                            ValorIVA = Convert.ToDouble(reader["ValorIVA"]),
                            Total = Convert.ToDouble(reader["Total"]),
                            FormaPago = Convert.ToString(reader["FormaPago"]),
                            Plazo = Convert.ToInt32(reader["Plazo"]),
                            Comprobante = Convert.ToString(reader["Comprobante"]),
                            Estado = Convert.ToBoolean(reader["Estado"]),
                            emi_ContribuyenteEspecial = Convert.ToString(reader["emi_ContribuyenteEspecial"]),
                            ret_CodDocumentoTipo = string.IsNullOrEmpty(reader["ret_CodDocumentoTipo"].ToString()) ? null : (string)(reader["ret_CodDocumentoTipo"]),
                            ret_Establecimiento = string.IsNullOrEmpty(reader["ret_Establecimiento"].ToString()) ? null : (string)(reader["ret_Establecimiento"]),
                            ret_Fecha = string.IsNullOrEmpty(reader["ret_Fecha"].ToString()) ? null : (DateTime?)(reader["ret_Fecha"]),
                            ret_FechaAutorizacion = string.IsNullOrEmpty(reader["ret_FechaAutorizacion"].ToString()) ? null : (DateTime?)(reader["ret_FechaAutorizacion"]),
                            ret_NumeroDocumento = string.IsNullOrEmpty(reader["ret_NumeroDocumento"].ToString()) ? null : (string)(reader["ret_NumeroDocumento"]),
                            ret_NumeroAutorizacion = string.IsNullOrEmpty(reader["ret_NumeroAutorizacion"].ToString()) ? null : (string)(reader["ret_NumeroAutorizacion"]),
                            ret_PuntoEmision = string.IsNullOrEmpty(reader["ret_PuntoEmision"].ToString()) ? null : (string)(reader["ret_PuntoEmision"]),
                            IdTipoCbte = string.IsNullOrEmpty(reader["IdTipoCbte"].ToString()) ? null : (int?)(reader["IdTipoCbte"]),
                            IdCbteCble = string.IsNullOrEmpty(reader["IdCbteCble"].ToString()) ? null : (decimal?)(reader["IdCbteCble"]),
                            EstadoCancelacion = string.IsNullOrEmpty(reader["EstadoCancelacion"].ToString()) ? null : (string)(reader["EstadoCancelacion"]),
                            descripcion_clas_prove = Convert.ToString(reader["descripcion_clas_prove"]),
                            EnviaXML = Convert.ToBoolean(reader["EnviaXML"])
                        });
                    }
                    reader.Close();
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

        public bool GuardarDB(cp_XML_Documento_Info info, ref bool GenerarXML)
        {
            try
            {
                bool PasarRetencion = false;
                if (Existe(info.IdEmpresa, info.emi_Ruc, info.CodDocumento, info.Establecimiento, info.PuntoEmision, info.NumeroDocumento) == 2)
                    return true;

                 EntitiesGeneral dbG = new EntitiesGeneral();
                var persona = dbG.tb_persona.Where(q => q.pe_cedulaRuc.Trim() == info.emi_Ruc.Trim()).FirstOrDefault();
                cp_proveedor proveedor = new cp_proveedor();
                using (EntitiesCuentasxPagar db = new EntitiesCuentasxPagar())
                {
                    info.ret_CodDocumentoTipo = info.ret_CodDocumentoTipo = "RETEN";

                    #region Validar si existe factura
                    if (persona != null)
                    {
                        proveedor = db.cp_proveedor.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdPersona == persona.IdPersona).FirstOrDefault();
                        if (proveedor != null)
                        {
                            var OG = db.cp_orden_giro.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdOrden_giro_Tipo == info.CodDocumento && q.co_serie == info.Establecimiento + "-" + info.PuntoEmision && q.co_factura == info.NumeroDocumento && q.Estado == "A" && q.IdProveedor == proveedor.IdProveedor && q.co_FechaFactura == info.FechaEmision).FirstOrDefault();
                            if (OG != null)
                            {
                                info.IdTipoCbte = OG.IdTipoCbte_Ogiro;
                                info.IdCbteCble = OG.IdCbteCble_Ogiro;

                                var retencion = db.cp_retencion.Where(q => q.IdEmpresa_Ogiro == OG.IdEmpresa && q.IdTipoCbte_Ogiro == OG.IdTipoCbte_Ogiro && q.IdCbteCble_Ogiro == OG.IdCbteCble_Ogiro && q.Estado == "A").FirstOrDefault();
                                if (retencion != null)
                                {
                                    GenerarXML = false;
                                    info.ret_Establecimiento = retencion.serie1;
                                    info.ret_PuntoEmision = retencion.serie2;
                                    info.ret_NumeroDocumento = retencion.NumRetencion;
                                    info.ret_Fecha = retencion.fecha;
                                    info.ret_FechaAutorizacion = retencion.Fecha_Autorizacion;
                                    info.ret_NumeroAutorizacion = retencion.NAutorizacion;
                                }
                                else
                                    PasarRetencion = true;
                            }
                        }                        
                    }
                    
                    #endregion

                    if (info.lstRetencion.Count > 0 && string.IsNullOrEmpty(info.ret_NumeroDocumento))
                    {
                        GenerarXML = true;
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
                        emi_ContribuyenteEspecial = info.emi_ContribuyenteEspecial,
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
                        ret_NumeroDocumento = info.ret_NumeroDocumento,
                        ret_FechaAutorizacion = info.ret_FechaAutorizacion,
                        ret_NumeroAutorizacion = info.ret_NumeroAutorizacion,
                        
                        IdTipoCbte = info.IdTipoCbte,
                        IdCbteCble = info.IdCbteCble,
                        IdUsuarioCreacion = info.IdUsuario,
                        FechaCreacion = DateTime.Now
                    });
                    int Secuencia = 1;
                    if (info.lstRetencion.Count > 0)
                    {                        
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
                    Secuencia = 1;
                    foreach (var item in info.lstDetalle)
                    {
                        db.cp_XML_DocumentoDet.Add(new cp_XML_DocumentoDet
                        {
                            IdEmpresa = info.IdEmpresa,
                            IdDocumento = info.IdDocumento,
                            Secuencia = Secuencia++,
                            NombreProducto = item.NombreProducto,
                            Cantidad = item.Cantidad,
                            Precio = item.Precio,
                            ValorIva = item.ValorIva,
                            PorcentajeIVA = item.PorcentajeIVA,
                            Total = item.Total
                        });
                    }
                    
                    info.Imagen = 2;
                    db.SaveChanges();

                    if (PasarRetencion && proveedor != null)
                    {
                        ContabilizarDocumento(info.IdEmpresa, info.IdDocumento, info.IdTipoCbte ?? 0, info.IdCbteCble ?? 0, info.IdUsuario, true);
                    }
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
                EntitiesGeneral dbg = new EntitiesGeneral();

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
                    documento.IdUsuarioModificacion = info.IdUsuario;
                    documento.FechaModificacion = DateTime.Now;

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

                    if (info.IdCbteCble != null)
                    {
                        #region Validar si existe factura
                        var persona = dbg.tb_persona.Where(q => q.pe_cedulaRuc.Trim() == info.emi_Ruc.Trim()).FirstOrDefault();
                        if (persona == null)
                            return true;
                        var proveedor = db.cp_proveedor.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdPersona == persona.IdPersona).FirstOrDefault();
                        if (proveedor != null)
                        {
                            var OG = db.cp_orden_giro.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdOrden_giro_Tipo == info.CodDocumento && q.co_serie == info.Establecimiento + "-" + info.PuntoEmision && q.co_factura == info.NumeroDocumento && q.Estado == "A" && q.IdProveedor == proveedor.IdProveedor && q.co_FechaFactura == info.FechaEmision).FirstOrDefault();
                            if (OG != null)
                            {
                                var retencion = db.cp_retencion.Where(q => q.IdEmpresa_Ogiro == OG.IdEmpresa && q.IdTipoCbte_Ogiro == OG.IdTipoCbte_Ogiro && q.IdCbteCble_Ogiro == OG.IdCbteCble_Ogiro && q.Estado == "A").FirstOrDefault();
                                if (retencion == null)
                                {
                                    ContabilizarDocumento(info.IdEmpresa, info.IdDocumento, info.IdTipoCbte ?? 0, info.IdCbteCble ?? 0, info.IdUsuario, true);    
                                }
                            }
                        }
                        #endregion
                        
                        
                    }
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
                    entity.IdUsuarioAnulacion = info.IdUsuario;
                    entity.FechaAnulacion = DateTime.Now;
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
                        IdProveedor = item.IdProveedor ?? 0,
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
        public cp_XML_Documento_Info GetInfo(int IdEmpresa, string CodDocumento, string Comprobante, string pe_cedulaRuc)
        {
            try
            {
                cp_XML_Documento_Info retorno = new cp_XML_Documento_Info();
                using (EntitiesCuentasxPagar db = new EntitiesCuentasxPagar())
                {
                    var info = db.cp_XML_Documento.Where(q => q.IdEmpresa == IdEmpresa && q.emi_Ruc == pe_cedulaRuc && q.CodDocumento == CodDocumento && q.Comprobante == Comprobante && q.Estado == true).FirstOrDefault();
                    if (info != null)
                    {
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
                            ret_PuntoEmision = info.ret_PuntoEmision,

                            IdTipoCbte = info.IdTipoCbte,
                            IdCbteCble = info.IdCbteCble,

                            ValidacionD = true,
                            ValidacionR = string.IsNullOrEmpty(info.ret_NumeroDocumento) ? false : true,
                            ValidacionC = info.IdTipoCbte == null ? false : true
                        };
                        if (retorno.IdTipoCbte != null && retorno.ValidacionR == false)
                        {
                            var Ret = db.cp_retencion.Where(q => q.IdEmpresa_Ogiro == retorno.IdEmpresa && q.IdTipoCbte_Ogiro == retorno.IdTipoCbte && q.IdCbteCble_Ogiro == retorno.IdCbteCble &&  q.Estado == "A").FirstOrDefault();
                            if (Ret != null)
                            {
                                retorno.ValidacionR = true;
                            }
                        }
                    }
                    else
                    {
                        var Proveedor = db.vwcp_proveedor_combo.Where(q => q.IdEmpresa == IdEmpresa && q.pe_cedularuc == pe_cedulaRuc).FirstOrDefault();
                        if (Proveedor != null)
                        {
                            var OG = db.cp_orden_giro.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrden_giro_Tipo == CodDocumento && (q.IdOrden_giro_Tipo + "-" + q.co_serie + "-" + q.co_factura) == Comprobante && q.IdProveedor == Proveedor.IdProveedor && q.Estado == "A" /*&& q.co_FechaFactura == info.FechaEmision*/).FirstOrDefault();
                            if (OG != null)
                            {
                                var Ret = db.cp_retencion.Where(q => q.IdEmpresa_Ogiro == OG.IdEmpresa && q.IdTipoCbte_Ogiro == OG.IdTipoCbte_Ogiro && q.IdCbteCble_Ogiro == OG.IdCbteCble_Ogiro &&  q.Estado == "A").FirstOrDefault();
                                retorno = new cp_XML_Documento_Info
                                {
                                    ValidacionC = true,
                                    ValidacionR = Ret == null ? false : true
                                };
                            }
                        }
                    }
                }
                return retorno;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public cp_XML_Documento_Info GetInfo(int IdEmpresa, decimal IdDocumento)
        {
            try
            {
                cp_XML_Documento_Info info = new cp_XML_Documento_Info();

                using (EntitiesCuentasxPagar db = new EntitiesCuentasxPagar())
                {
                    var Entity = db.cp_XML_Documento.Where(q => q.IdEmpresa == IdEmpresa && q.IdDocumento == IdDocumento).FirstOrDefault();
                    if (Entity == null)
                        return null;

                    info = new cp_XML_Documento_Info
                    {
                        IdEmpresa = Entity.IdEmpresa,
                        IdDocumento = Entity.IdDocumento,
                        Comprobante = Entity.Comprobante,
                        XML = Entity.XML,
                        Tipo = Entity.Tipo,
                        emi_RazonSocial = Entity.emi_RazonSocial,
                        emi_NombreComercial = Entity.emi_NombreComercial,
                        emi_Ruc = Entity.emi_Ruc,
                        emi_DireccionMatriz = Entity.emi_DireccionMatriz,
                        emi_ContribuyenteEspecial = Entity.emi_ContribuyenteEspecial,
                        ClaveAcceso = Entity.ClaveAcceso,
                        CodDocumento = Entity.CodDocumento,
                        Establecimiento = Entity.Establecimiento,
                        PuntoEmision = Entity.PuntoEmision,
                        NumeroDocumento = Entity.NumeroDocumento,
                        FechaEmision = Entity.FechaEmision,
                        rec_RazonSocial = Entity.rec_RazonSocial,
                        rec_Identificacion = Entity.rec_Identificacion,
                        Subtotal0 = Entity.Subtotal0,
                        SubtotalIVA = Entity.SubtotalIVA,
                        Porcentaje = Entity.Porcentaje,
                        ValorIVA = Entity.ValorIVA,
                        Total = Entity.Total,
                        FormaPago = Entity.FormaPago,
                        Plazo = Entity.Plazo,
                        ret_CodDocumentoTipo = Entity.ret_CodDocumentoTipo,
                        ret_Establecimiento = Entity.ret_Establecimiento,
                        ret_PuntoEmision = Entity.ret_PuntoEmision,
                        ret_NumeroDocumento = Entity.ret_NumeroDocumento,
                        ret_Fecha = Entity.ret_Fecha,
                        ret_FechaAutorizacion = Entity.ret_FechaAutorizacion,
                        ret_NumeroAutorizacion = Entity.ret_NumeroAutorizacion,
                        Estado = Entity.Estado,
                        IdTipoCbte = Entity.IdTipoCbte,
                        IdCbteCble = Entity.IdCbteCble
                    };
                }

                return info;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool ContabilizarDocumento(int IdEmpresa, decimal IdDocumento, int IdTipoCbte, decimal IdCbteCble, string IdUsuario, bool GenerarRetencion)
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
                            var ret = db.cp_retencion.Where(q=> q.IdEmpresa == IdEmpresa && q.IdTipoCbte_Ogiro == IdTipoCbte && q.IdCbteCble_Ogiro == IdCbteCble && q.Estado =="A").FirstOrDefault();
                            if (ret != null)
                            {
                                db.SaveChanges();

                                var rel = db.cp_retencion_x_ct_cbtecble.Where(q => q.rt_IdEmpresa == IdEmpresa && q.rt_IdRetencion == ret.IdRetencion).FirstOrDefault();
                                if (rel == null)
                                {
                                    odataR.ContabilizarRetencion(Entity.IdEmpresa, ret.IdRetencion, IdUsuario);
                                }

                                return true;
                            }

                            var lst = db.cp_XML_Documento_Retencion.Where(q => q.IdEmpresa == IdEmpresa && q.IdDocumento == IdDocumento).ToList();
                            if (lst.Count != 0)
                            {
                                decimal IdRetencion = 0;
                                
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
                                    re_Tiene_RFuente = lst.Where(q => q.re_tipoRet == "RTF").Count() > 0 ? "S" : "N",
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

        public bool EliminarRetencion(int IdEmpresa, decimal IdDocumento, string IdUsuario)
        {
            try
            {
                using (EntitiesCuentasxPagar db = new EntitiesCuentasxPagar())
                {
                    var xml = db.cp_XML_Documento.Where(q => q.IdEmpresa == IdEmpresa && q.IdDocumento == IdDocumento).FirstOrDefault();
                    if (xml != null)
                    {
                        int SecuenciaAnu = odataAnulacion.GetId(IdEmpresa,IdDocumento);
                        db.cp_XML_DocumentoRetAnulado.Add(new cp_XML_DocumentoRetAnulado
                        {
                            IdEmpresa = xml.IdEmpresa,
                            IdDocumento = xml.IdDocumento,
                            SecuenciaAnu = SecuenciaAnu,
                            Comprobante = xml.Comprobante,
                            emi_Ruc = xml.emi_Ruc,
                            emi_RazonSocial = xml.emi_RazonSocial,
                            FechaEmision = xml.FechaEmision,
                            ret_CodDocumentoTipo = xml.ret_CodDocumentoTipo,
                            ret_Establecimiento = xml.ret_Establecimiento,
                            ret_PuntoEmision = xml.ret_PuntoEmision,
                            ret_NumeroDocumento = xml.ret_NumeroDocumento,
                            ret_Fecha = xml.ret_Fecha,
                            ret_FechaAutorizacion = xml.ret_FechaAutorizacion,
                            ret_NumeroAutorizacion = xml.ret_NumeroAutorizacion,
                            IdUsuarioAnulacion = xml.IdUsuarioAnulacion,
                            FechaAnulacion = DateTime.Now
                        });

                        xml.ret_NumeroDocumento = null;
                        xml.ret_NumeroAutorizacion = null;
                        xml.ret_Fecha = null;

                        var xmldet = db.cp_XML_Documento_Retencion.Where(q => q.IdEmpresa == IdEmpresa && q.IdDocumento == IdDocumento).ToList();
                        foreach (var item in xmldet)
                        {
                            db.cp_XML_DocumentoRetAnuladoDet.Add(new cp_XML_DocumentoRetAnuladoDet
                            {
                                IdEmpresa = item.IdEmpresa,
                                IdDocumento = item.IdDocumento,
                                SecuenciaAnu = SecuenciaAnu,
                                Secuencia = item.Secuencia,
                                re_tipoRet = item.re_tipoRet,
                                re_baseRetencion = item.re_baseRetencion,
                                IdCodigo_SRI = item.IdCodigo_SRI,
                                re_Codigo_impuesto = item.re_Codigo_impuesto,
                                re_Porcen_retencion = item.re_Porcen_retencion,
                                re_valor_retencion = item.re_valor_retencion
                            });
                            db.cp_XML_Documento_Retencion.Remove(item);
                        }
                        db.SaveChanges();
                    }

                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
