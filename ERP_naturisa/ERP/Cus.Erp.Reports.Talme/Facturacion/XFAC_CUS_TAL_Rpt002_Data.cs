using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Talme.Facturacion
{
    public class XFAC_CUS_TAL_Rpt002_Data
    {




        List<XFAC_CUS_TAL_Rpt002_Info> listado = new List<XFAC_CUS_TAL_Rpt002_Info>();


        public List<XFAC_CUS_TAL_Rpt002_Info> Obtener_data(int idempresa, int idsucursal, int idbodega, decimal idordendespacho,
            ref string mensaje)
        {

            try
            {


                using (EntitiesFacturacion_Rpt DB = new EntitiesFacturacion_Rpt())
                {


                    var Consulta = from od in DB.vwFAC_CUS_TAL_Rpt002
                                   where od.IdEmpresa == idempresa && od.IdSucursal == idsucursal && od.IdBodega == idbodega
                                   && od.IdOrdenDespacho == idordendespacho
                                   select od;


                    foreach (var item in Consulta)
                    {
                        XFAC_CUS_TAL_Rpt002_Info Info = new XFAC_CUS_TAL_Rpt002_Info();
                        Info.Cantidad_det = item.Cantidad_det;
                        Info.Cedula_ruc_clie = item.Cedula_ruc_clie;
                        Info.codigo_prod = item.codigo_prod;
                        Info.correo_clie = item.correo_clie;
                        Info.costo_det = item.costo_det;
                        Info.DespachoAbiert = item.DespachoAbiert;
                        Info.detallexItems_det = item.detallexItems_det;
                        Info.direccion_clie = item.direccion_clie;
                        Info.direccion_empr = item.direccion_empr;
                        Info.Fecha = item.Fecha;
                        Info.Fecha_vct = item.Fecha_vct;
                        Info.IdBodega = item.IdBodega;
                        Info.IdCliente = item.IdCliente;
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdOrdenDespacho = item.IdOrdenDespacho;
                        Info.IdProducto = item.IdProducto;
                        Info.IdSucursal = item.IdSucursal;
                        Info.IdTransportista = item.IdTransportista;
                        Info.IdVendedor = item.IdVendedor;
                        Info.Iva_det = item.Iva_det;
                        //Info.logo_empre = item.logo_empre;//
                        Info.Nom_Bodega = item.Nom_Bodega;
                        Info.Nom_Cliente = item.Nom_Cliente;
                        Info.Nom_Empresa = item.Nom_Empresa;
                        Info.Nom_produc = item.Nom_produc;
                        Info.Nom_Sucursal = item.Nom_Sucursal;
                        Info.Nom_Transportista = item.Nom_Transportista;
                        Info.Observacion = item.Observacion;
                        Info.Peso_det = item.Peso_det;
                        Info.Plazo = item.Plazo;
                        Info.Porcent_des_Uni__det = item.Porcent_des_Uni__det;
                        Info.Precio_det = item.Precio_det;
                        Info.Precio_Final__det = item.Precio_Final__det;
                        Info.Razon_social_clie = item.Razon_social_clie;
                        Info.ruc_empre = item.ruc_empre;
                        Info.Subtotal_det = item.Subtotal_det;
                        Info.telefono_empre = item.telefono_empre;
                        Info.telefonoOfi_clie = item.telefonoOfi_clie;
                        Info.Total_det = item.Total_det;
                        Info.Total_kilos = item.Total_kilos;
                        Info.TotalQuint = item.TotalQuint;
                        Info.Valor_desc_uni__det = item.Valor_desc_uni__det;
                        listado.Add(Info);

                    }
                }
                //return Lst;
                return listado;
            }
            catch (Exception ex)
            {
                //string arreglo = ToString();
                //tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                //tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                //oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                //mensaje = ex.InnerException + " " + ex.Message;
                return new List<XFAC_CUS_TAL_Rpt002_Info>();
            }
        }


    }
}