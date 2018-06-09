using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Roles
{
    public class XROLES_Rpt009_Info
    {
        public int IdEmpresa { get; set; }
        public int IdNomina_Tipo { get; set; }
        public int IdNomina_TipoLiqui { get; set; }
        public int IdPeriodo { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string Nombres { get; set; }
        public string ca_descripcion { get; set; }
        public string Centro_costo { get; set; }
        public string pe_FechaIni { get; set; }
        public string Af_DescripcionCorta { get; set; }

        public double Valor { get; set; }
        public string FechaInicio { get; set; }
        public string EstadoContrato { get; set; }
        public Nullable<int> pe_anio { get; set; }
        public Nullable<int> pe_mes { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string CatalogoGrupo { get; set; }
        public Nullable<System.DateTime> em_fechaSalida { get; set; }
        public int Orden { get; set; }
        public string Descripcion { get; set; }
        public string EstadoEmpleado { get; set; }
        public string Grupo { get; set; }
       public string Antiguedad { get; set; }

    }
}
