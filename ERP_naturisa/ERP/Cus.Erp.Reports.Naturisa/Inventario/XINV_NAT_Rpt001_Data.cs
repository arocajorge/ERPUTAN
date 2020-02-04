using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Naturisa.Inventario
{
    public class XINV_NAT_Rpt001_Data
    {
        public List<XINV_NAT_Rpt001_Info> consultar_data(int IdEmpresa, decimal IdGuia, ref String mensaje)
        {
            try
            {
                List<XINV_NAT_Rpt001_Info> listadedatos = new List<XINV_NAT_Rpt001_Info>();

                using (EntitiesInventario_Rpt_Natu guiaderemision = new EntitiesInventario_Rpt_Natu())
                {
                    listadedatos = (from h in guiaderemision.vwINV_NAT_Rpt001
                                    where h.IdEmpresa == IdEmpresa
                                    && h.IdGuia == IdGuia
                                    select new XINV_NAT_Rpt001_Info
                                    {
                                        IdEmpresa = h.IdEmpresa,
                                        IdGuia = h.IdGuia,
                                        TipoDetalle = h.TipoDetalle,
                                        secuencia = h.secuencia,
                                        IdEmpresa_OC = h.IdEmpresa_OC,
                                        IdSucursal_OC = h.IdSucursal_OC,
                                        IdOrdenCompra_OC = h.IdOrdenCompra_OC,
                                        Secuencia_OC = h.Secuencia_OC,
                                        observacion = h.observacion,
                                        IdProducto = h.IdProducto,
                                        Cantidad_enviar = h.Cantidad_enviar,
                                        nom_producto = h.nom_producto,
                                        CantOC = h.CantOC,
                                        Observacion_OC = h.Observacion_OC,
                                        Num_Fact = h.Num_Fact,
                                        IdProveedor = h.IdProveedor,
                                        nom_proveedor = h.nom_proveedor,
                                        NumGuia = h.NumGuia,
                                        IdSucursal_Partida = h.IdSucursal_Partida,
                                        Nom_Sucursal_Partida = h.Nom_Sucursal_Partida,
                                        Direc_sucu_Partida = h.Direc_sucu_Partida,
                                        IdSucursal_Llegada = h.IdSucursal_Llegada,
                                        Nom_Sucursal_LLegada = h.Nom_Sucursal_LLegada,
                                        Direc_sucu_Llegada = h.Direc_sucu_Llegada,
                                        IdTransportista = h.IdTransportista,
                                        nom_transportista = h.nom_transportista,
                                        cedu_transportista = h.cedu_transportista,
                                        Fecha = h.Fecha,
                                        Fecha_Traslado = h.Fecha_Traslado,
                                        Fecha_llegada = h.Fecha_llegada,
                                        IdMotivo_Traslado = h.IdMotivo_Traslado,
                                        Hora_Traslado = h.Hora_Traslado,
                                        Hora_Llegada = h.Hora_Llegada,
                                        nom_motivo = h.nom_motivo,
                                        pr_codigo = h.pr_codigo,
                                        placa = h.Placa
                                    }).ToList();
                    
                }
                return listadedatos;
            }
            catch (Exception ex)
            {
                return new List<XINV_NAT_Rpt001_Info>();
            }
        }
    }
}
