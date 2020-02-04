using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.ERP.Reports.Grafinpren.Facturacion
{
   public class XFAC_GRAF_Rpt002_Info
    {

       public int IdEmpresa { get; set; }
       public int IdSucursal { get; set; }
       public int IdBodega { get; set; }
       public string IdTipoDocumento { get; set; }
       public string numDocumento { get; set; }
       public decimal IdCbteVta { get; set; }
       public decimal IdCliente { get; set; }
       public string nom_cliente { get; set; }
       public DateTime vt_fecha { get; set; }
       public int IdCalendario { get; set; }
       public int ? AnioFiscal { get; set; }
       public string NombreMes { get; set; }
       public string NombreCortoFecha { get; set; }
       public decimal IdProducto { get; set; }
       public string nom_producto { get; set; }
       public double vt_cantidad { get; set; }
       public double vt_PrecioFinal { get; set; }
       public double vt_Subtotal { get; set; }
       public double vt_iva { get; set; }
       public double vt_total { get; set; }
       public string nom_sucursal { get; set; }
       public string IdCategoria { get; set; }
       public int ? IdLinea { get; set; }
       public int ? IdGrupo { get; set; }
       public int ? IdSubgrupo { get; set; }
       public string nom_categoria { get; set; }
       public string nom_linea { get; set; }
       public string nom_grupo { get; set; }
       public string nom_subgrupo { get; set; }
       public int Idtipo_cliente { get; set; }
       public string nom_tipo_cliente { get; set; }
       public string vt_Observacion { get; set; }
       public int IdVendedor { get; set; }
       public string nom_vendedor { get; set; }
       public string num_op { get; set; }
       public DateTime ? fecha_op { get; set; }
       public string num_cotizacion { get; set; }
       public DateTime ? fecha_cotizacion { get; set; }
       public double ? porc_comision { get; set; }
       public double ? IdEquipo { get; set; }
       public string nom_Equipo { get; set; }
       public int ?IdMes { get; set; }
       public string Estado { get; set; }
       public int Secuencia { get; set; }
    }
}
