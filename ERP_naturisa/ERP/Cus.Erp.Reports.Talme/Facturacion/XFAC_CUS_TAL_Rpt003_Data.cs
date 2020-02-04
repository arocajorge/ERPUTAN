using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cus.Erp.Reports.Talme.Facturacion;


namespace Cus.Erp.Reports.Talme.Facturacion
{
   public  class XFAC_CUS_TAL_Rpt003_Data
    {

       public XFAC_CUS_TAL_Rpt003_Data()
       {

       }

       public List<XFAC_CUS_TAL_Rpt003_Info> obtener_list_data(int idempresa,int idsucursal ,int idbodega ,decimal idGuiaRemision,ref string mensaje )
       {
           try
           {


               List<XFAC_CUS_TAL_Rpt003_Info> Olista = new List<XFAC_CUS_TAL_Rpt003_Info>();

               using (EntitiesFacturacion_Rpt DB = new EntitiesFacturacion_Rpt())
               {

                   var select = from q in DB.vwFAC_CUS_TAL_Rpt003
                                where q.IdEmpresa == idempresa && q.IdSucursal == idsucursal 
                                && q.IdBodega==idbodega && q.IdGuiaRemision==idGuiaRemision
                                select q;


                   foreach (var item in select)
                   {
                       XFAC_CUS_TAL_Rpt003_Info ItemA = new XFAC_CUS_TAL_Rpt003_Info();
                       
                       ItemA.IdEmpresa= item.IdEmpresa;
                       ItemA.IdSucursal=item.IdSucursal;
                       ItemA.IdBodega= item.IdBodega;
                       ItemA.IdGuiaRemision=item.IdGuiaRemision;
                       ItemA.CodGuiaRemision=item.CodGuiaRemision;
                       ItemA.Serie1=item.Serie1;
                       ItemA.Serie2=item.Serie2;
                       ItemA.NumGuia_Preimpresa=item.NumGuia_Preimpresa;
                       ItemA.IdCliente=item.IdCliente;
                       ItemA.IdVendedor=item.IdVendedor;
                       ItemA.IdTransportista=item.IdTransportista;
                       ItemA.gi_fecha=item.gi_fecha;
                       ItemA.gi_plazo = (item.gi_plazo == null) ? 0 : Convert.ToInt32(item.gi_plazo);
                       ItemA.gi_fech_venc = (item.gi_fech_venc == null) ? DateTime.Now : Convert.ToDateTime(item.gi_fech_venc);  
                       ItemA.gi_Observacion=item.gi_Observacion;
                       ItemA.gi_TotalKilos=item.gi_TotalKilos;
                       ItemA.gi_TotalQuintales=item.gi_TotalQuintales;
                       ItemA.IdUsuario=item.IdUsuario;
                       ItemA.gi_flete=item.gi_flete;
                       ItemA.gi_interes=item.gi_interes;
                       ItemA.gi_seguro=item.gi_seguro;
                       ItemA.gi_OtroValor1=item.gi_OtroValor1;
                       ItemA.gi_OtroValor2=item.gi_OtroValor2;
                       ItemA.Secuencia=item.Secuencia;
                       ItemA.IdProducto=item.IdProducto;
                       ItemA.gi_cantidad=item.gi_cantidad;
                       ItemA.gi_Precio=item.gi_Precio;
                       ItemA.gi_PorDescUnitario=item.gi_PorDescUnitario;
                       ItemA.gi_DescUnitario=item.gi_DescUnitario;
                       ItemA.gi_PrecioFinal=item.gi_PrecioFinal;
                       ItemA.gi_Subtotal=item.gi_Subtotal;
                       ItemA.gi_iva=item.gi_iva;
                       ItemA.gi_total=item.gi_total;
                       ItemA.gi_detallexItems=item.gi_detallexItems;
                       ItemA.gi_peso=(item.gi_peso==null)? 0: Convert.ToDouble(item.gi_peso) ;
                       ItemA.nom_empresa=item.nom_empresa;
                       ItemA.ruc_empresa=item.ruc_empresa;
                       //ItemA.logo_empresa=item.logo_empresa;
                       ItemA.nom_sucursal=item.nom_sucursal;
                       ItemA.nom_bodega=item.nom_bodega;
                       ItemA.nom_cliente=item.nom_cliente;
                       ItemA.cod_producto=item.cod_producto;
                       ItemA.nom_producto=item.nom_producto;
                       ItemA.nom_transportista=item.nom_transportista;
                       ItemA.razon_social_transportista=item.razon_social_transportista;
                       ItemA.cedula_ruc_transportista=item.cedula_ruc_transportista;
                       ItemA.cedula_ruc_cliente=item.cedula_ruc_cliente;
                       ItemA.direccion_cliente=item.direccion_cliente;
                       ItemA.direccion_empresa = item.direccion_empresa;
                       
                       Olista.Add(ItemA);
                   }


               }


               mensaje = "ok";
               return Olista;

           }
           catch (Exception ex)
           {
               mensaje = "error" + ex.Message;
               return new List<XFAC_CUS_TAL_Rpt003_Info>();   
           }  
       }
    }
}
