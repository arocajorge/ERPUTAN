using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_historico_vacaciones_x_empleado_Info
    {
        public string Tipo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaRetorno { get; set; }
        public int DiasGanados { get; set; }
        public int DiasTomados { get; set; }
        public int DiasPendientes { get; set; }
        public double RemuneracionAnual { get; set; }
        public double Vacaciones { get; set; }
        public string Observacion { get; set; }

        public Bitmap Ico { get; set; }

        //DEREK 14/01/2014
        public int IdHis_Vacaciones { get; set; }
        public int Secuencia { get; set; }
        public bool check { get; set; }

        //DEREK 16/01/2014
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public double otro_valor { get; set; }
        public ro_historico_vacaciones_x_empleado_Info()
        {

        }
    }
}
