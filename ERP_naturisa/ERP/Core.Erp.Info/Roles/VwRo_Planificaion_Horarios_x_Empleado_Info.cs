using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
   public  class VwRo_Planificaion_Horarios_x_Empleado_Info
    {

      
       public string pe_nombreCompleto { get; set; }
       public string NombreCortoFecha { get; set; }
       public string Inicial_del_Dia { get; set; }
       public decimal IdRegistro { get; set; }
       public string Descripcion { get; set; }
       public DateTime fecha { get; set; }
       public decimal ? IdHorario { get; set; }
       public decimal IdEmpleado { get; set; }
       public int IdEmpresa { get; set; }
       public string Estado { get; set; }
       public string Su_Descripcion { get; set; }
       public int IdSucursal { get; set; }
       public string Departamento { get; set; }
       public string ca_descripcion { get; set; }
       public int IdCalendario { get; set; }


       public VwRo_Planificaion_Horarios_x_Empleado_Info()
       {

       }


       
    }

       
}
