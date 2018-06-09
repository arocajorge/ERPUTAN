using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxCobrar
{
   public class XCXC_Rpt013_Info
    {

       public int IdEmpresa { get; set; }
       public string nom_sucursal { get; set; }
       public Nullable<decimal> IdCobro { get; set; }
       public DateTime Fecha_cobro { get; set; }
       public Nullable<DateTime> Fecha_Retencion { get; set; }
       public string Num_Retencion { get; set; }
       public string IdCobro_tipo { get; set; }
       public decimal IdCliente { get; set; }
       public string nom_cliente { get; set; }   
       public string ruc_ced { get; set; }
       public double ? PorcentajeRet { get; set; }
       public double ? Base_RIva { get; set; }
       public double ? Base_RFte { get; set; }
       public double ? Valor_Ret { get; set; }
       public decimal IdCbteVta { get; set; }
       public string num_factura { get; set; }
       public DateTime Fecha_Fact { get; set; }
       public string vt_tipoDoc { get; set; }
       public string Tipo_Retencion { get; set; }
       public string nomTipo_Retencion { get; set; }
       public string nomTipoCobro { get; set; }
    }
}
