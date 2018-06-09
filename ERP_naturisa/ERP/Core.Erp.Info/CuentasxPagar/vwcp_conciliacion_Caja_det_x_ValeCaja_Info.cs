using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxPagar
{
  public  class vwcp_conciliacion_Caja_det_x_ValeCaja_Info
    {


       public int IdEmpresa { get; set; }
       public decimal IdConciliacion_Caja { get; set; }
       public DateTime Fecha { get; set; }
       public int IdCaja { get; set; }
       public string IdEstadoCierre { get; set; }
       public string Observacion { get; set; }
       public int? IdEmpresa_op { get; set; }
       public decimal? IdOrdenPago_op { get; set; }
       public string IdCtaCble { get; set; }
       public int Secuencia { get; set; } 
       public int IdEmpresa_movcaja { get; set; }

       public decimal IdCbteCble_movcaja { get; set; }
       public int IdTipocbte_movcaja { get; set; }
       public string cm_Signo { get; set; }

        public string cm_beneficiario { get; set; }
        public int IdTipoMovi { get; set; }
        public string cm_observacion { get; set; }
        public DateTime cm_fecha { get; set; }
        public string Estado { get; set; }
        public string IdUsuario_Aprueba { get; set; }

        
        
        public int Secuencia_DetcajMovi { get; set; }

      public double cr_Valor { get; set; }
      public string nom_TipoMovi { get; set; }
      public string nom_Caja { get; set; }
      public string nom_EstadoCierre { get; set; }

      public string IdCtaCble_ValeCaja { get; set; }

      public string IdTipo_Persona { get; set; }
      public decimal? IdEntidad { get; set; }
      public decimal? IdPersona { get; set; }
      public string IdCentroCosto { get; set; }
      public string IdCentroCosto_sub_centro_costo { get; set; }
      public Nullable<decimal> IdTipoFlujo { get; set; }
      
      public vwcp_conciliacion_Caja_det_x_ValeCaja_Info(){}

    }
}
