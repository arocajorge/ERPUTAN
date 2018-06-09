using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.ActivoFijo
{
    public class vwAf_Depreciacion_Info
    {

        public int IdEmpresa { get; set; }
        public decimal IdDepreciacion { get; set; }
        public int IdTipoDepreciacion { get; set; }
        public string Cod_Depreciacion { get; set; }
        public int IdPeriodo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha_Depreciacion { get; set; }
        public string IdUsuario { get; set; }
        public string nom_tipo_depreciacion { get; set; }
        public string cod_tipo_depreciacion { get; set; }
        public double Valor_Depreciacion { get; set; }
        public double Valor_Depre_Acum { get; set; }
        public double Valor_Importe { get; set; }
        public string Estado { get; set; }

        public vwAf_Depreciacion_Info()
        {

        }
    }
}
