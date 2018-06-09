using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cus.Erp.Reports.Talme.Facturacion
{
   public  class XFAC_CUS_TAL_Rpt001_Info
    {

       public int IdEmpresa { get; set; }
       public string em_nombre { get; set; }
       public int IdSucursal { get; set; }
       public string Su_Descripcion { get; set; }
       public int IdBodega { get; set; }
       public string bo_Descripcion { get; set; }
       public decimal IdPedido { get; set; }
       public decimal IdCliente { get; set; }
       public decimal IdPersona { get; set; }
       public string pe_nombreCompleto { get; set; }
       public DateTime cp_fecha { get; set; }
       public int cp_diasPlazo { get; set; }
       public DateTime cp_fechaVencimiento { get; set; }
       public string cp_observacion { get; set; }
       public string IdEstadoAprobacion{ get; set; }
       public int Secuencial { get; set; }
       public decimal IdProducto { get; set; }
       public string pr_codigo { get; set; }
       public string pr_descripcion { get; set; }
       public double dp_cantidad{ get; set; }
       public double dp_precio { get; set; }
       public double dp_PorDescuento { get; set; }
       public double cp_desUni{ get; set; }
       public double cp_PrecioFinal { get; set; }
       public double dp_subtotal { get; set; }
       public double dp_iva	 { get; set; }
       public double dp_total{ get; set; }
       public double dp_peso{ get; set; }
       public decimal interes{ get; set; }
       public decimal transporte{ get; set; }
       public decimal otro1 { get; set; }
       public decimal otro2 { get; set; }
       public string IdEstadoProduccion { get; set; }
       public string pe_cedulaRuc{ get; set; }
       public string  pe_direccion  { get; set; }
       public string  pe_telefonoOfic    { get; set; }
       public string  pe_telefonoCasa   { get; set; }
       public string  pe_correo  { get; set; }
       public string   pe_razonSocial { get; set; }




       public XFAC_CUS_TAL_Rpt001_Info()
       {

       }
    }
}
