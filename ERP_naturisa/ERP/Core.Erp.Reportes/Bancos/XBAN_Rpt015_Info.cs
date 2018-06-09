using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Bancos
{
   public class XBAN_Rpt015_Info
    {

       public int mba_IdEmpresa { get; set; }
       public decimal mba_IdCbteCble { get; set; }
       public int mba_IdTipocbte { get; set; }
       public int mcj_Secuencia { get; set; }

       public string cm_observacion { get; set; }


       public int IdEmpresa { get; set; }
       public string nom_sucursal { get; set; }
       public decimal IdCbteCble { get; set; }
       public int IdTipocbte { get; set; }
       public string nom_Tipocbte { get; set; }
       public string Beneficiario { get; set; }
       public string IdCobro_tipo { get; set; }
       public DateTime ? Fecha_Cobro { get; set; }
       public double ? cr_Valor { get; set; }


    }
}
