using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
   public class fa_tarifario_facturacion_x_cliente_Af_Depreciacion_Det_Info
   {
       public int IdEmpresa { get; set; }
       public decimal IdDepreciacion { get; set; }
       public decimal IdTarifario { get; set; }
       public int Secuencia { get; set; }
       public int IdTipoDepreciacion { get; set; }
       public int IdActivoFijo { get; set; }
       public string Concepto { get; set; }
       public double Valor_Compra { get; set; }
       public double Valor_Salvamento { get; set; }
       public int Vida_Util { get; set; }
       public double Porc_Depreciacion { get; set; }
       public double Valor_Depreciacion { get; set; }
       public double Valor_Depre_Acum { get; set; }
       public double Valor_Importe { get; set; }
       public string Af_Nombre { get; set; }
    }
}
