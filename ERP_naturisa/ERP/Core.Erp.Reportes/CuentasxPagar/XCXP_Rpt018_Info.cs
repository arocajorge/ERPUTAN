using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
   public class XCXP_Rpt018_Info
    {
       public int IdEmpresa { get; set; }      	
       public decimal IdCbteCble_Ogiro	{ get; set; }
       public int IdTipoCbte_Ogiro { get; set; }
       public string IdOrden_giro_Tipo	{ get; set; }
       public string Documento { get; set; }
       public decimal IdProveedor { get; set; }
       public DateTime co_fechaOg	{ get; set; }
       public DateTime  co_FechaFactura	{ get; set; }
       public string  co_observacion	{ get; set; }
       public double  co_subtotal_iva	{ get; set; }
       public double  co_subtotal_siniva	{ get; set; }
       public double  co_baseImponible	{ get; set; }
       public double co_Por_iva	{ get; set; }
       public double co_valoriva	{ get; set; }
       public double  co_total	{ get; set; }
       public double  co_valorpagar	{ get; set; }
       public string   Estado	{ get; set; }
       public int ? IdSucursal	{ get; set; }
       public string  Num_Autorizacion	{ get; set; }
       public decimal  IdRetencion	{ get; set; }
       public string   serie	{ get; set; }
       public string  NumRetencion	{ get; set; }
       public string  re_tipoRet	{ get; set; }
       public double  re_baseRetencion	{ get; set; }
       public int IdCodigo_SRI	{ get; set; }
       public string re_Codigo_impuesto	{ get; set; }
       public double re_Porcen_retencion	{ get; set; }
       public double  re_valor_retencion	{ get; set; }
       public string  co_descripcion	{ get; set; }
       public string  IdTipoSRI	{ get; set; }
       public string  nom_proveedor	{ get; set; }
       public string  nom_sucursal	{ get; set; }

       public string nom_TipoDocumento { get; set; }
       public string pe_cedulaRuc { get; set; }
    }
}
