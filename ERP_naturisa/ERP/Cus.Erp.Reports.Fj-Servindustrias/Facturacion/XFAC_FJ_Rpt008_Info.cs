using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
   public class XFAC_FJ_Rpt008_Info
   {
       public int IdEmpresa { get; set; }
       public decimal IdEmpleado { get; set; }
       public int IdPeriodo { get; set; }
       public string pe_cedulaRuc { get; set; }
       public string Nombres { get; set; }
       public string ca_descripcion { get; set; }
       public string zo_descripcion { get; set; }
       public string ru_descripcion { get; set; }
       public int Orden { get; set; }
       public double Valor { get; set; }
       public Nullable<bool> rub_visible_reporte { get; set; }
       public string de_descripcion { get; set; }
       public double SueldoActual { get; set; }

       public Nullable<int> IdanioFiscal { get; set; }
       public Nullable<int> pe_mes { get; set; }
       public Nullable<System.DateTime> pe_FechaIni { get; set; }
       public Nullable<System.DateTime> pe_FechaFin { get; set; }
       public Nullable<System.DateTime> em_fecha_ingreso { get; set; }
       public Nullable<System.DateTime> em_fechaSalida { get; set; }
       public string em_nombre { get; set; }
       public byte[] em_logo { get; set; }

       public string Periodo { get; set; }
    }
}
