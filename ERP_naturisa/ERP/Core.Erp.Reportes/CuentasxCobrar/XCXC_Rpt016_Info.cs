using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxCobrar
{
   public class XCXC_Rpt016_Info
    {
       public int IdEmpresa { get; set; }
       public int IdSucursal { get; set; }
       public decimal IdCobro { get; set; }
       public int secuencial { get; set; }
       public int ? IdBodega_Cbte { get; set; }
       public decimal IdCbte_vta_nota { get; set; }
       public string IdCobro_tipo { get; set; }
       public string CodDocumentoTipo { get; set; }
       public string Serie1 { get; set; }
       public string Serie2 { get; set; }
       public string NumNota_Impresa { get; set; }
       public decimal IdCliente { get; set; }
       public string nom_cliente { get; set; }
       public string sc_observacion { get; set; }
       public DateTime cr_fecha { get; set; }
       public string tc_descripcion { get; set; }
       public double ? PorcentajeRet { get; set; }
       public double dc_ValorPago { get; set; }
       public string cr_NumDocumento { get; set; }
       public double ? Base { get; set; }
       public string num_documento { get; set; }
       public double ? sc_subtotal { get; set; }
       public double ? sc_iva { get; set; }
       public double ? sc_total { get; set; }



    }
}
