using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    public class ro_turno_x_tb_dia_Info
    {
        public int IdEmpresa { get; set; }
        public decimal  IdTurno { get; set; }
        public byte idDia { get; set; }
        public string Dia { get; set; }
        public Boolean  Activo { get; set; }
        public ro_turno_x_tb_dia_Info()
        {

        }

    }
}
