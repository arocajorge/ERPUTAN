using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt023_Info
    {
        public int IdEmpresa { get; set; }
        public string IdCtaCble { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdUsuario { get; set; }
        public string IdCtaCblePadre { get; set; }
        public string Naturaleza { get; set; }
        public string NombreCuenta { get; set; }
        public string NombreCentroCosto { get; set; }
        public bool EsCuentaMovimiento { get; set; }
        public int NivelCuenta { get; set; }
        public decimal Saldo { get; set; }
        public decimal SaldoNaturaleza { get; set; }
        public string TipoCuenta { get; set; }
    }
}
