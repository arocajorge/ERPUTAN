using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_AnioFiscal_Info
    {
        public int IdanioFiscal { get; set; }
        public DateTime af_fechaIni { get; set; }
        public DateTime af_fechaFin { get; set; }
        public string af_estado { get; set; }
        // vista
        public int IdEmpresa { get; set; }
        public string IdCtaCble { get; set; }
        public string pc_Cuenta { get; set; }
        public int IdNivelCta { get; set; }
        public string IdGrupoCble { get; set; }
        public string IdTipoCtaCble { get; set; }
        public string gc_GrupoCble { get; set; }
        public ct_anio_fiscal_x_cuenta_utilidad_Info anio_fiscal_x_cuenta_utilidad_Info { get; set; }
        public ct_AnioFiscal_Info()
        {
            anio_fiscal_x_cuenta_utilidad_Info = new ct_anio_fiscal_x_cuenta_utilidad_Info();
        }
    }

}
