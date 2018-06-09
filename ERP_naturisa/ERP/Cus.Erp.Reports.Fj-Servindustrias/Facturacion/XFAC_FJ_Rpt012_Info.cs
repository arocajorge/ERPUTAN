using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
   public class XFAC_FJ_Rpt012_Info
   {
       public int IdEmpresa { get; set; }
       public decimal IdPrestamo { get; set; }
       public int NumCuota { get; set; }
       public double SaldoInicial { get; set; }
       public double Interes { get; set; }
       public double AbonoCapital { get; set; }
       public double TotalCuota { get; set; }
       public double Saldo { get; set; }
       public System.DateTime FechaPago { get; set; }
       public decimal IdPreFacturacion { get; set; }
       public int IdPeriodo { get; set; }
       public string IdCentroCosto_cc { get; set; }
       public double Valor { get; set; }



       public string em_nombre { get; set; }
       public byte[] em_logo { get; set; }
    }
}
