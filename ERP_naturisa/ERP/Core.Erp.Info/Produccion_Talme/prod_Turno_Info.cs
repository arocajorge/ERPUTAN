using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Produccion_Talme
{

    public class prod_Turno_Info
    {


        public int IdEmpresa { get; set; }
        public int IdTurno { get; set; }
        public TimeSpan? HoraInicio { get; set; }
        public TimeSpan? HoraFin { get; set; }
        public string Descripcion { get; set; }


        public prod_Turno_Info() { }
    }
	
}
