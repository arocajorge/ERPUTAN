using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxPagar;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_XML_DocumentoDet_Data
    {
        public List<cp_XML_DocumentoDet_Info> GetList(int IdEmpresa, decimal IdDocumento)
        {
            try
            {
                List<cp_XML_DocumentoDet_Info> Lista = new List<cp_XML_DocumentoDet_Info>();

                using (EntitiesCuentasxPagar db = new EntitiesCuentasxPagar())
                {
                    var lst = db.cp_XML_DocumentoDet.Where(q => q.IdEmpresa == IdEmpresa && q.IdDocumento == IdDocumento).ToList();
                    foreach (var item in lst)
                    {
                        Lista.Add(new cp_XML_DocumentoDet_Info
                        {
                            IdEmpresa = item.IdEmpresa,
                            IdDocumento = item.IdDocumento,
                            Secuencia = item.Secuencia,
                            NombreProducto = item.NombreProducto,
                            Cantidad = item.Cantidad,
                            Precio = item.Precio,
                            PorcentajeIVA = item.PorcentajeIVA,
                            ValorIva = item.ValorIva,
                            Total = item.Total
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
