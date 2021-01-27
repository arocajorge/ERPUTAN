using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Info.Inventario
{
    public class in_ProvisionIngresosPorOC_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdProvision { get; set; }
        public string IdCtaCble { get; set; }
        public DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public int IdTipoCbte { get; set; }
        public decimal IdCbteCble { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Estado { get; set; }
        public string IdUsuario { get; set; }

        public List<ct_Cbtecble_det_Info> ListaDiario { get; set; }
        public List<in_ProvisionIngresosPorOCDet_Info> ListaDetalle { get; set; }
    }
}
