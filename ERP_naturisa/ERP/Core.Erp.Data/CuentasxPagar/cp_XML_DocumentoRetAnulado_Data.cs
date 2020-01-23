using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_XML_DocumentoRetAnulado_Data
    {
        public List<cp_XML_DocumentoRetAnulado_Info> GetList(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<cp_XML_DocumentoRetAnulado_Info> Lista = new List<cp_XML_DocumentoRetAnulado_Info>();

                using (EntitiesCuentasxPagar db = new EntitiesCuentasxPagar())
                {
                    var lst = db.cp_XML_DocumentoRetAnulado.Where(q => q.IdEmpresa == IdEmpresa && FechaIni <= q.FechaEmision && q.FechaEmision <= FechaFin).ToList();
                    foreach (var item in lst)
                    {
                        Lista.Add(new cp_XML_DocumentoRetAnulado_Info
                        {
                            IdEmpresa = item.IdEmpresa,
                            IdDocumento = item.IdDocumento,
                            SecuenciaAnu = item.SecuenciaAnu,
                            Comprobante = item.Comprobante,
                            emi_Ruc = item.emi_Ruc,
                            emi_RazonSocial = item.emi_RazonSocial,
                            FechaEmision = item.FechaEmision,
                            ret_CodDocumentoTipo = item.ret_CodDocumentoTipo,
                            ret_Establecimiento = item.ret_Establecimiento,
                            ret_PuntoEmision = item.ret_PuntoEmision,
                            ret_NumeroDocumento = item.ret_NumeroDocumento,
                            ret_Fecha = item.ret_Fecha,
                            ret_FechaAutorizacion = item.ret_FechaAutorizacion,
                            ret_NumeroAutorizacion = item.ret_NumeroAutorizacion,
                            IdUsuarioAnulacion = item.IdUsuarioAnulacion,
                            FechaAnulacion = item.FechaAnulacion
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


        public int GetId(int IdEmpresa, decimal IdDocumento)
        {
            try
            {
                int ID = 1;

                using (EntitiesCuentasxPagar db = new EntitiesCuentasxPagar())
                {
                    int cont = db.cp_XML_DocumentoRetAnulado.Where(q => q.IdEmpresa == IdEmpresa && q.IdDocumento == IdDocumento).Count();
                    if (cont > 0)
                        ID = db.cp_XML_DocumentoRetAnulado.Where(q => q.IdEmpresa == IdEmpresa && q.IdDocumento == IdDocumento).Max(q => q.SecuenciaAnu) + 1;
                }

                return ID;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
