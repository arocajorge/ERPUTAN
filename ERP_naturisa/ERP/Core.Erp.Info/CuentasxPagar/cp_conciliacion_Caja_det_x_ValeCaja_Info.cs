using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Caja;

namespace Core.Erp.Info.CuentasxPagar
{
   public class cp_conciliacion_Caja_det_x_ValeCaja_Info
    {

        public int IdEmpresa { get; set; }
        public decimal IdConciliacion_Caja { get; set; }
        public int Secuencia { get; set; }
        public int IdEmpresa_movcaja { get; set; }
        public decimal IdCbteCble_movcaja { get; set; }
        public int IdTipocbte_movcaja { get; set; }
        public decimal IdPersona { get; set; }
        public string IdCtaCble { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public caj_Caja_Movimiento_Info Info_Caja_Movi { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
              
       public cp_conciliacion_Caja_det_x_ValeCaja_Info()
       {
           Info_Caja_Movi = new caj_Caja_Movimiento_Info();
       }
    }
}
