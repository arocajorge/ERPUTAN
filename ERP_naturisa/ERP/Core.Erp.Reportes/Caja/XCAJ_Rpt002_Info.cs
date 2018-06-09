using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Caja
{
    public class XCAJ_Rpt002_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdTipocbte { get; set; }
        public string Tipo_Cbte { get; set; }
        public DateTime cm_fecha { get; set; }
        public string cm_Signo { get; set; }
        public string cm_beneficiario { get; set; }
        public string cm_observacion { get; set; }
        public string Estado { get; set; }
        public int IdCaja { get; set; }
        public string nom_caja { get; set; }
        public int IdSucursal { get; set; }
        public string nom_sucursal { get; set; }
        public int IdTipoMovi { get; set; }
        public string nom_TipoMovi { get; set; }
        public string nom_empresa { get; set; }
        public string IdCobro_tipo { get; set; }
        public double cr_Valor { get; set; }
        public string cr_NumDocumento { get; set; }
        public decimal IdTipoFlujo { get; set; }
        public string nom_TipoFlujo { get; set; }
        public string NombreComercial { get; set; }
        public decimal? IdPersona { get; set; }
        public string IdTipo_Persona { get; set; }
        public decimal? IdEntidad { get; set; }

    }
}
