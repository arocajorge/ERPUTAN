using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Reportes.Contabilidad
{
   public  class XCONTA_Rpt006_Info
    {

       public int IdEmpresa { get; set; }
       public string nom_empresa { get; set; }
       public string ruc_empresa { get; set; }

       public int IdPeriodo { get; set; }
       public string IdCtaCble { get; set; }
       public string nom_cuenta { get; set; }
       
       public string IdCtaCblePadre { get; set; }
       public string nom_cuentaPadre { get; set; }
       
       public decimal IdCbteCble { get; set; }
       public string CodCbteCble { get; set; }



       public int IdTipocbte { get; set; }
       public DateTime FechaCbte { get; set; }
       
       public string sTipocbte { get; set; }
       public string Concepto { get; set; }
       public double ? Debito { get; set; }
       public double ? Credito { get; set; }
       public double ? Saldo { get; set; }
       public double ? SaldoInicial { get; set; }
       public double ? SaldoFinal { get; set; }

       public string nom_grupo_punto_cargo { get; set; }
       public string nom_punto_cargo { get; set; }
       public Image Icono_Cbte_externo { get; set; }

       public string IdCentro_Costo { get; set; }
       public string nom_centro_costo { get; set; }
       public string pc_clave_corta { get; set; }

    }
}
