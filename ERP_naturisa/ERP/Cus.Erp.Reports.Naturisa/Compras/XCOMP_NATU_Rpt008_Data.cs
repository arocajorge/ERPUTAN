using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.Compras
{
    public class XCOMP_NATU_Rpt008_Data
    {
        public List<XCOMP_NATU_Rpt008_Info> GetList(int IdEmpresa, decimal IdOrdenPedido)
        {
            try
            {
                List<XCOMP_NATU_Rpt008_Info> Lista = new List<XCOMP_NATU_Rpt008_Info>();

                using (EntitiesCompras_natu_rpt db = new EntitiesCompras_natu_rpt())
                {
                    var lst = db.vwCOMP_NATU_Rpt008.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido).ToList();
                    Lista = lst.Select(q => new XCOMP_NATU_Rpt008_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdOrdenPedido = q.IdOrdenPedido,
                        Secuencia = q.Secuencia,
                        IdProducto = q.IdProducto,
                        pr_descripcion = q.pr_descripcion,
                        IdCotizacion = q.IdCotizacion,
                        cd_cantidad = q.cd_cantidad,
                        cd_precioCompra = q.cd_precioCompra,
                        cd_porc_des = q.cd_porc_des,
                        cd_descuento = q.cd_descuento,
                        cd_precioFinal = q.cd_precioFinal,
                        cd_subtotal = q.cd_subtotal,
                        IdCod_Impuesto = q.IdCod_Impuesto,
                        Por_Iva = q.Por_Iva,
                        cd_iva = q.cd_iva,
                        cd_total = q.cd_total,
                        IdUnidadMedida = q.IdUnidadMedida,
                        IdPunto_cargo = q.IdPunto_cargo,
                        nom_punto_cargo = q.nom_punto_cargo,
                        IdSolicitante = q.IdSolicitante,
                        IdDepartamento = q.IdDepartamento,
                        nom_solicitante = q.nom_solicitante,
                        nomUnidadMedida = q.nomUnidadMedida,
                        EstadoDetalle = q.EstadoDetalle,
                        opd_EstadoProceso = q.opd_EstadoProceso,
                        IdSucursalDestino = q.IdSucursalDestino,
                        IdSucursalOrigen = q.IdSucursalOrigen,
                        SecuenciaCot = q.SecuenciaCot,
                        cd_DetallePorItem = q.cd_DetallePorItem,
                        cp_Observacion = q.cp_Observacion,
                        cp_ObservacionAdicional = q.cp_ObservacionAdicional,
                        cp_Fecha = q.cp_Fecha,
                        Comprador = q.Comprador,
                        opd_Detalle = q.opd_Detalle,
                        pe_nombreCompleto = q.pe_nombreCompleto,
                        SucursalOrigen = q.SucursalOrigen,
                        SucursalDestino = q.SucursalDestino,
                        SubtotalIva = q.SubtotalIva,
                        SubtotalSinIva = q.SubtotalSinIva,
                        op_Observacion = q.op_Observacion,
                        op_Fecha = q.op_Fecha
                    }).ToList();
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
