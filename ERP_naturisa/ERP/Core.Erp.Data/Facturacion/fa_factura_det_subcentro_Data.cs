using Core.Erp.Info.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion
{
    public class fa_factura_det_subcentro_Data
    {
        public List<fa_factura_det_subcentro_Info> GetList(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                List<fa_factura_det_subcentro_Info> Lista;

                using (EntitiesFacturacion db = new EntitiesFacturacion())
                {
                    Lista = db.fa_factura_det_subcentro.Where(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega && q.IdCbteVta == IdCbteVta).Select(q => new fa_factura_det_subcentro_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdSucursal = q.IdSucursal,
                        IdBodega = q.IdBodega,
                        IdCbteVta = q.IdCbteVta,
                        Secuencia = q.Secuencia,
                        vt_cantidad = q.vt_cantidad,
                        vt_Precio = q.vt_Precio,
                        vt_PorDescUnitario = q.vt_PorDescUnitario,
                        vt_DescUnitario = q.vt_DescUnitario,
                        vt_PrecioFinal = q.vt_PrecioFinal,
                        vt_Subtotal = q.vt_Subtotal,
                        IdCod_Impuesto_Iva = q.IdCod_Impuesto_Iva,
                        vt_por_iva = q.vt_por_iva,
                        vt_iva = q.vt_iva,
                        vt_total = q.vt_total,
                        IdCentroCosto = q.IdCentroCosto,
                        IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,                        
                    }).ToList();

                    Lista.ForEach(q => q.IdRegistro = q.IdCentroCosto + "-" + q.IdCentroCosto_sub_centro_costo);
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
