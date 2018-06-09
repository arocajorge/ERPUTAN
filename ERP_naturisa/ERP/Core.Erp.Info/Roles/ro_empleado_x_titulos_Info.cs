using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//05/07/2013
namespace Core.Erp.Info.Roles
{
    public class ro_empleado_x_titulos_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int Secuencia { get; set; }
        public DateTime fecha { get; set; }
        public string IdInstitucion { get; set; }
        public string IdTitulo { get; set; }
        public string Observacion { get; set; }

        public ro_empleado_x_titulos_Info ()
        {
            fecha = DateTime.Now;
        
        }
    }
}
