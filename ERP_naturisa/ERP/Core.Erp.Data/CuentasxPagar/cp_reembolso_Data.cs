using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_reembolso_Data
    {
        public List<cp_reembolso_Info> GetList(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
        {
            try
            {
                List<cp_reembolso_Info> Lista = new List<cp_reembolso_Info>();

                using (EntitiesCuentasxPagar db = new EntitiesCuentasxPagar())
                {
                    /*
                    var lst = (from a in db.cp_reembolso
                               join b in db.cp_TipoDocumento
                               on new { TipoDoc_CodSRI = a.TipoDoc_CodSRI } equals new { TipoDoc_CodSRI = b.CodTipoDocumento }
                               select new cp_reembolso_Info
                               {
                                   IdEmpresa = a.IdEmpresa,
                                   IdCbteCble_Ogiro = a.IdCbteCble_Ogiro,
                                   IdTipoCbte_Ogiro = a.IdTipoCbte_Ogiro,
                                   IdReembolso = a.IdReembolso,
                                   TipoIdProveedor = a.TipoIdProveedor,
                                   IdentificacionProveedor = a.IdentificacionProveedor,
                                   TipoDoc_CodSRI = a.TipoDoc_CodSRI,
                                   Establecimiento = a.Establecimiento,
                                   Punto_Emision = a.Punto_Emision,
                                   Secuencial = a.Secuencial,
                                   Autorizacion = a.Autorizacion,
                                   Fecha_Emision = a.Fecha_Emision,
                                   TarifaIVAcero = a.TarifaIVAcero,
                                   TarifaIVADiferentecero = a.TarifaIVADiferentecero,
                                   TarifaNoObjetoIVA = a.TarifaNoObjetoIVA,
                                   TarifaExcentaDeIVA = a.TarifaExcentaDeIVA,
                                   TotalBaseImponible = a.TotalBaseImponible,
                                   MontoICE = a.MontoICE,
                                   MontoIVA = a.MontoIVA,
                                   b.cod
                               }).ToList();*/
                    var lst = db.cp_reembolso.Where(q => q.IdEmpresa == IdEmpresa && q.IdTipoCbte_Ogiro == IdTipoCbte && q.IdCbteCble_Ogiro == IdCbteCble).ToList();
                    foreach (var item in lst)
                    {
                        Lista.Add(new cp_reembolso_Info
                        {
                            IdEmpresa = item.IdEmpresa,
                            IdCbteCble_Ogiro = item.IdCbteCble_Ogiro,
                            IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro,
                            IdReembolso = item.IdReembolso,
                            TipoIdProveedor = item.TipoIdProveedor,
                            IdentificacionProveedor = item.IdentificacionProveedor,
                            TipoDoc_CodSRI = item.TipoDoc_CodSRI,
                            Establecimiento = item.Establecimiento,
                            Punto_Emision = item.Punto_Emision,
                            Secuencial = item.Secuencial,
                            Autorizacion = item.Autorizacion,
                            Fecha_Emision = item.Fecha_Emision,
                            TarifaIVAcero = item.TarifaIVAcero,
                            TarifaIVADiferentecero = item.TarifaIVADiferentecero,
                            TarifaNoObjetoIVA = item.TarifaNoObjetoIVA,
                            TarifaExcentaDeIVA = item.TarifaExcentaDeIVA,
                            TotalBaseImponible = item.TotalBaseImponible,
                            MontoICE = item.MontoICE,
                            MontoIVA = item.MontoIVA,
                            CodigoTipoIdentificacion = item.TipoIdProveedor == "RUC" ? "01" : (item.TipoIdProveedor == "CED" ? "02" : "03")
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
    }
}
