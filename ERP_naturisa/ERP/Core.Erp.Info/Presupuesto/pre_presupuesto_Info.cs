using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Presupuesto
{
    public class pre_presupuesto_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPresupuesto { get; set; }
        public string IdAnio { get; set; }
        public int Secuencia { get; set; }
        public string CodigoPresupuesto { get; set; }
        public string IdCtaCble { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdTipoRubro { get; set; }
        public string CodRubro { get; set; }
        public string NombreRubro { get; set; }
        public double Enero { get; set; }
        public double febrero { get; set; }
        public double Marzo { get; set; }
        public double Abril { get; set; }
        public double Mayo { get; set; }
        public double Junio { get; set; }
        public double Julio { get; set; }
        public double Agosto { get; set; }
        public double Septiembre { get; set; }
        public double Octubre { get; set; }
        public double Noviembre { get; set; }
        public double Diciembre { get; set; }
        public double Total { get; set; }
        public Boolean check { get; set; }

        public string NPresupuesto { get; set; }
        public decimal IdPresupuestoCompuesto { get; set; }
        public pre_presupuesto_Info()
        {

        }
    }
}
