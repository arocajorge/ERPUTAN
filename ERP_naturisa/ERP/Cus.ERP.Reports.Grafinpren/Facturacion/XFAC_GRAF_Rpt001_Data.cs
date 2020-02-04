using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Cus.ERP.Reports.Grafinpren.Facturacion
{
    public class XFAC_GRAF_Rpt001_Data
    {

        public List<XFAC_GRAF_Rpt001_Info> Lista_Guias(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdGuia, ref  string mensaje)
        {
            try
            {
                List<XFAC_GRAF_Rpt001_Info> Lista = new List<XFAC_GRAF_Rpt001_Info>();
                using (EntitiesFacturacion_Rpt_GRAF Context = new EntitiesFacturacion_Rpt_GRAF())
                {
                    var selectGuia = from q in Context.vwFAC_GRAF_Rpt001
                                     where q.IdEmpresa == IdEmpresa
                                              && q.IdBodega == IdBodega
                                              && q.IdSucursal == IdSucursal
                                              && q.IdGuiaRemision == IdGuia
                                     select q;


                    foreach (var item in selectGuia)
                    {
                        XFAC_GRAF_Rpt001_Info info = new XFAC_GRAF_Rpt001_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdBodega = item.IdBodega;
                        info.IdSucursal = item.IdSucursal;
                        info.IdGuiaRemision = item.IdGuiaRemision;
                        info.CodGuiaRemision = item.CodGuiaRemision;
                        info.IdCliente = item.IdCliente;
                        info.pe_razonSocial = item.pe_razonSocial;
                        info.gi_Observacion = item.gi_Observacion;
                        info.Secuencia = item.Secuencia;
                        info.gi_cantidad = item.gi_cantidad;
                        info.gi_Precio = item.gi_Precio;
                        info.gi_PorDescUnitario = item.gi_PorDescUnitario;
                        info.gi_DescUnitario = item.gi_DescUnitario;
                        info.gi_PrecioFinal = item.gi_PrecioFinal;
                        info.gi_Subtotal = item.gi_Subtotal;
                        info.gi_iva = item.gi_iva;
                        info.gi_total = item.gi_total;
                        info.gi_detallexItems = item.gi_detallexItems;
                        info.Nombre_Transportista = item.Nombre_Transportista;
                        info.Nombre_Producto = item.Nombre_Producto;
                        info.Numero_OP = item.Numero_OP;
                        info.Num_Cotizacion = item.Num_Cotizacion;
                        info.Nom_Maquina = item.Nom_Maquina;
                        info.Direccion_Destino = item.Direccion_Destino;
                        info.Direccion_Origen = item.Direccion_Origen;
                        info.ruta = item.ruta;
                        info.placa = item.placa;
                        info.gi_FechaFinTraslado = item.gi_FechaFinTraslado;
                        info.gi_FechaIniTraslado = item.gi_FechaIniTraslado;
                        info.gi_fecha = item.gi_fecha;
                        Lista.Add(info);
                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }
    }
}
