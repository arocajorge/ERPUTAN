using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Cus.Erp.Reports.Talme.Facturacion
{
   public  class XFAC_CUS_TAL_Rpt002_Info
    {
        public int IdEmpresa{ get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdOrdenDespacho { get; set; }
        public decimal IdCliente { get; set; }
        public int  IdVendedor { get; set; }
        public decimal IdTransportista { get; set; }
        public DateTime Fecha { get; set; }
        public int Plazo { get; set; }
        public DateTime Fecha_vct { get; set; }
        public string Observacion { get; set; }
        public double Total_kilos { get; set; }
        public double TotalQuint { get; set; }
        public string  DespachoAbiert { get; set; }
        public decimal IdProducto { get; set; }
        public double Cantidad_det { get; set; }
        public double Precio_det { get; set; }
        public double Porcent_des_Uni__det { get; set; }
        public double Valor_desc_uni__det { get; set; }
        public double Precio_Final__det { get; set; }
        public double Subtotal_det { get; set; }
        public double Iva_det { get; set; }	
        public double Total_det { get; set; }
        public double Peso_det { get; set; }
        public string detallexItems_det { get; set; }
        public double costo_det { get; set; }
        public string Nom_Transportista { get; set; }
        public string Nom_Empresa { get; set; }
        public string Nom_Sucursal { get; set;}
        public string Nom_Bodega { get; set; }
        public string Nom_Cliente { get; set; }
        public string Razon_social_clie { get; set; }
        public string Cedula_ruc_clie { get; set; }
        public string direccion_clie { get; set; }
        public string telefonoOfi_clie { get; set; }
        public string correo_clie { get; set; }
        public string codigo_prod	 { get; set; }
        public string Nom_produc { get; set; }
        public Image logo_empre { get; set; }
        public string ruc_empre { get; set; }
        public string telefono_empre { get; set; }	
        public string direccion_empr { get; set; }	
       

       public XFAC_CUS_TAL_Rpt002_Info()
       {

       }
    }
}