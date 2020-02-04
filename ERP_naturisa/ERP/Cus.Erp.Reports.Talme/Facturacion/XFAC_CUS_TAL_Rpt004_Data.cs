using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Talme.Facturacion
{
    public class XFAC_CUS_TAL_Rpt004_Data
    {
        List<XFAC_CUS_TAL_Rpt004_info> listado = new List<XFAC_CUS_TAL_Rpt004_info>();


        public List<XFAC_CUS_TAL_Rpt004_info> Obtener_data(int idempresa, int idsucursal, int idbodega, decimal IdCbte_vta,
            ref string mensaje)
        {
            try
            {




                using (EntitiesFacturacion_Rpt DB = new EntitiesFacturacion_Rpt())
                {


                    var Consulta = from fa in DB.vwFAC_CUS_TAL_Rpt004
                                   where fa.IdEmpresa == idempresa && fa.IdSucursal == idsucursal 
                                   && fa.IdBodega == idbodega
                                   && fa.IdCbteVta == IdCbte_vta
                                   select fa;


                    foreach (var item in Consulta)
                    {
                        XFAC_CUS_TAL_Rpt004_info Info = new XFAC_CUS_TAL_Rpt004_info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.cod_producto = item.cod_producto;
                        Info.CodCbteVta = item.CodCbteVta;
                        Info.IdBodega = item.IdBodega;
                        Info.IdCaja = item.IdCaja;
                        Info.IdCbteVta = item.IdCbteVta;
                        Info.IdCliente = item.IdCliente;
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdProducto = item.IdProducto;
                        Info.IdSucursal = item.IdSucursal;
                        Info.IdVendedor = item.IdVendedor;
                        Info.nom_caja = item.nom_caja;
                        Info.nom_cliente = item.nom_cliente;
                        Info.nom_producto = item.nom_producto;
                        Info.nom_vendedor = item.nom_vendedor;
                        Info.Secuencia = item.Secuencia;
                        Info.vt_autorizacion = item.vt_autorizacion;
                        Info.vt_cantidad = item.vt_cantidad;
                        Info.vt_costo = item.vt_costo;
                        Info.vt_DescUnitario = item.vt_DescUnitario;
                        Info.vt_detallexItems = item.vt_detallexItems;
                        Info.vt_fech_venc = item.vt_fech_venc;
                        Info.vt_fecha = item.vt_fecha;
                        Info.vt_flete = item.vt_flete;
                        Info.vt_interes = item.vt_interes;
                        Info.vt_iva = item.vt_iva;
                        Info.vt_NumFactura = item.vt_NumFactura;
                        Info.vt_Observacion = item.vt_Observacion;
                        Info.vt_OtroValor1 = item.vt_OtroValor1;
                        Info.vt_OtroValor2 = item.vt_OtroValor2;
                        Info.vt_Peso = (item.vt_Peso == null) ? 0 : Convert.ToInt32( item.vt_Peso);
                        Info.vt_plazo = item.vt_plazo;
                        Info.vt_PorDescUnitario = item.vt_PorDescUnitario;
                        Info.vt_Precio = item.vt_Precio;
                        Info.vt_seguro = item.vt_seguro;
                        Info.vt_serie1 = item.vt_serie1;
                        Info.vt_serie2 = item.vt_serie2;
                        Info.vt_Subtotal = item.vt_Subtotal;
                        Info.vt_tipo_venta = item.vt_tipo_venta;
                        Info.vt_tipoDoc = item.vt_tipoDoc;
                        Info.vt_total = item.vt_total;
                        Info.vt_PrecioFinal = item.vt_PrecioFinal;
                        Info.correo_cliente= item.correo_cliente;
                        Info.direccion_cliente = item.direccion_cliente;
                        Info.cedu_ruc_cliente = item.cedu_ruc_cliente;
                        Info.telefono_cliente = item.telef_cliente;
                        item.razon_social_cliente = item.razon_social_cliente;
                          

                        listado.Add(Info);

                    }
                }
                
                return listado;
            }
            catch (Exception ex)
            {
                //string arreglo = ToString();
                //tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                //tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                //oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                //mensaje = ex.InnerException + " " + ex.Message;
                return new List<XFAC_CUS_TAL_Rpt004_info>();
            }
        }


    }
}
    

