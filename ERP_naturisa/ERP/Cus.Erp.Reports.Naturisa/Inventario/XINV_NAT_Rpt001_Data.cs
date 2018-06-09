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
                    var select = from h in guiaderemision.vwINV_NAT_Rpt001
                                 where h.IdEmpresa == IdEmpresa
                                 && h.IdGuia == IdGuia
                                 select h;

                    foreach (var item in select)
                    {
                        XINV_NAT_Rpt001_Info Info = new XINV_NAT_Rpt001_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdGuia = item.IdGuia;
                        Info.TipoDetalle = item.TipoDetalle;
                        Info.secuencia = item.secuencia;
                        Info.IdEmpresa_OC = item.IdEmpresa_OC;
                        Info.IdSucursal_OC = item.IdSucursal_OC;
                        Info.IdOrdenCompra_OC = item.IdOrdenCompra_OC;
                        Info.Secuencia_OC = item.Secuencia_OC;
                        Info.observacion = item.observacion;
                        Info.IdProducto = item.IdProducto;
                        Info.Cantidad_enviar = item.Cantidad_enviar;
                        Info.nom_producto = item.nom_producto;
                        Info.CantOC = item.CantOC;
                        Info.Observacion_OC = item.Observacion_OC;
                        Info.Num_Fact = item.Num_Fact;
                        Info.IdProveedor = item.IdProveedor;
                        Info.nom_proveedor = item.nom_proveedor;
                        Info.NumGuia = item.NumGuia;
                        Info.IdSucursal_Partida = item.IdSucursal_Partida;
                        Info.Nom_Sucursal_Partida = item.Nom_Sucursal_Partida;
                        Info.Direc_sucu_Partida = item.Direc_sucu_Partida;
                        Info.IdSucursal_Llegada = item.IdSucursal_Llegada;
                        Info.Nom_Sucursal_LLegada = item.Nom_Sucursal_LLegada;
                        Info.Direc_sucu_Llegada = item.Direc_sucu_Llegada;
                        Info.IdTransportista = item.IdTransportista;
                        Info.nom_transportista = item.nom_transportista;
                        Info.cedu_transportista = item.cedu_transportista;
                        Info.Fecha = item.Fecha;
                        Info.Fecha_Traslado = item.Fecha_Traslado;
                        Info.Fecha_llegada = item.Fecha_llegada;
                        Info.IdMotivo_Traslado = item.IdMotivo_Traslado;
                        Info.Hora_Traslado = item.Hora_Traslado;
                        Info.Hora_Llegada = item.Hora_Llegada;
                        Info.nom_motivo = item.nom_motivo;
                        Info.pr_codigo = item.pr_codigo;
                        listadedatos.Add(Info);
                    }
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
