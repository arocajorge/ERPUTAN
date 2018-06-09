using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxPagar
{
 public class cp_conciliacion_Caja_det_Info
    {

         public int IdEmpresa { get; set; }
         public decimal IdConciliacion_Caja { get; set; }
         public int IdCaja { get; set; }
         public int Secuencia { get; set; }
         public int IdEmpresa_OGiro { get; set; }
         public decimal IdCbteCble_Ogiro { get; set; }
         public int IdTipoCbte_Ogiro { get; set; }

         public decimal IdEntidad { get; set; }
         public string IdBeneficiario { get; set; }
         public decimal? IdPersona { get; set; }
         public string IdTipo_Persona { get; set; }
         
         public int IdTipocbte { get; set; }
         public string IdCentroCosto { get; set; }
         public string IdCentroCosto_sub_centro_costo { get; set; }
         public Nullable<int> IdPunto_cargo { get; set; }
         public Nullable<int> IdPunto_cargo_grupo { get; set; }
         public int IdTipoMovi { get; set; }
         public string cm_observacion { get; set; }
         public string IdCtaCble_caja { get; set; }
         public string IdCtaCble_Tipo_Mov { get; set; }
         public int IdSucursal { get; set; }
         public string cm_beneficiario { get; set; }
         public double cm_valor { get; set; }
         public cp_orden_giro_Info Info_Orden_Giro { get; set; }
         public DateTime Fecha { get; set; }
         public string IdUsuario { get; set; }
         public DateTime Fecha_Transac { get; set; }
         public string nom_pc { get; set; }
         public string ip { get; set; }
         public bool Esta_en_base { get; set; }
         public decimal Valor_a_aplicar { get; set; }
         public string Tipo_documento { get; set; }
         public Nullable<int> IdEmpresa_OP { get; set; }
         public Nullable<decimal> IdOrdenPago_OP { get; set; }
         public string pe_cedulaRuc { get; set; }
      public  cp_conciliacion_Caja_det_Info()
      {
          Info_Orden_Giro = new cp_orden_giro_Info();
      }
    }
}
