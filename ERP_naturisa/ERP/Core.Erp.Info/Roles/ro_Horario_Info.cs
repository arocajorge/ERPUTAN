using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
  public  class ro_Horario_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdHorario { get; set; }
        public Nullable<TimeSpan> HoraIni { get; set; }
        public Nullable<TimeSpan> HoraFin { get; set; }
        public int ToleranciaEnt { get; set; }
        public int ToleranciaSal { get; set; }
        public Nullable<TimeSpan> InicioEntrada { get; set; }
        public Nullable<TimeSpan> FinalEntrada { get; set; }
        public Nullable<TimeSpan> InicioSal { get; set; }
        public Nullable<TimeSpan> FinalSalida { get; set; }
        public Nullable<TimeSpan> SalLunch { get; set; }
        public Nullable<TimeSpan> RegLunch { get; set; }
        public int Min_Almuerzo { get; set; }
        //public TimeSpan TotalHoras { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotiAnula { get; set; }
        public Nullable<int> Tolerancia_Minuto { get; set; }
        public Nullable<int> Tolerancia_Hora { get; set; }
        //VISTA
        public Boolean Check { get; set; }
        public Boolean CheckDefault { get; set; }


        public ro_Horario_Info()
        {

        }

        public TimeSpan TotalHoras { get; set; }
    }
}
