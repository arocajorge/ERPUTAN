using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_XML_Documento_Data
    {
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
                    });
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
    }
}
