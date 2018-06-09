using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.ActivoFijo
{
    public class vwAf_Valores_Depre_Contabilizar_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdDepreciacion { get; set; }
        public int IdTipoDepreciacion { get; set; }
        public string Cod_Depreciacion { get; set; }
        public int IdPeriodo { get; set; }
        
        public int IdActivoFijo { get; set; }
        public int IdActijoFijoTipo { get; set; }
        public string Af_Nombre { get; set; }
        public string Af_Descripcion { get; set; }
        public string cod_tipo_depreciacion { get; set; }

        public string Descripcion { get; set; }
        public DateTime Fecha_Depreciacion { get; set; }
        public double Valor_Depreciacion { get; set; }
        public double Valor_a_contabilizar { get; set; }
        public string IdCtaCbleDepre { get; set; }
        public string IdCtaCbleGastos { get; set; }

        //public string IdCentroCostoDepre { get; set; }
        //public string IdCentroCostoGastos { get; set; }

        public string ObservacionCbteCble { get; set; }


        public vwAf_Valores_Depre_Contabilizar_Info()
        {

        }
    }
}
