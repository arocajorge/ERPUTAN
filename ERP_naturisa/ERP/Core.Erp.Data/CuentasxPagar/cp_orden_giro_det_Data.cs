using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_orden_giro_det_Data
    {
        public List<cp_orden_giro_det_Info> GetList(int IdEmpresa, int IdTipoCbte, decimal IdCbteCle)
        {
            try
            {
                List<cp_orden_giro_det_Info> Lista = new List<cp_orden_giro_det_Info>();

                using (EntitiesCuentasxPagar db = new EntitiesCuentasxPagar())
                {
                    var lst = db.cp_orden_giro_det.Where(q => q.IdEmpresa == IdEmpresa && q.IdTipoCbte_Ogiro == IdTipoCbte && q.IdCbteCble_Ogiro == IdCbteCle).ToList();
                    foreach (var item in lst)
                    {
                        Lista.Add(new cp_orden_giro_det_Info
                        {
                            IdEmpresa = item.IdEmpresa,
                            IdCbteCble_Ogiro = item.IdCbteCble_Ogiro,
                            IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro,
                            Secuencia = item.Secuencia,
                            IdProducto = item.IdProducto,
                            IdUnidadMedida = item.IdUnidadMedida,
                            Cantidad = item.Cantidad,
                            CostoUni = item.CostoUni,
                            PorDescuento = item.PorDescuento,
                            DescuentoUni = item.DescuentoUni,
                            CostoUniFinal = item.CostoUniFinal,
                            Subtotal = item.Subtotal,
                            IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva,
                            PorIva = item.PorIva,
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
