using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Derek 13/12/2013
//Gastos Personales
//Derek Mejía Soria
//ultima modificacion : 08/01/2014
namespace Core.Erp.Info.Roles
{
    public class ro_empleado_gastos_perso_Info
    {

        public List<ro_empleado_gastos_perso_x_Gastos_deduci_Info> oListRo_empleado_gastos_perso_x_Gastos_deduci_Info = new List<ro_empleado_gastos_perso_x_Gastos_deduci_Info>();
        public List<ro_empleado_gastos_perso_x_otros_gast_deduci_Info> oListRo_empleado_gastos_perso_x_otros_gast_deduci_Info = new List<ro_empleado_gastos_perso_x_otros_gast_deduci_Info>();

        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int Anio_fiscal { get; set; }
        public DateTime fecha { get; set; }
        public string observacion { get; set; }
        public string Estado { get; set; }
        public string Tipo_Iden { get; set; }
        public string Num_Identificacion { get; set; }
        public string Apellidos_Nombres { get; set; }
        public string telefono { get; set; }
        public string calle_prin { get; set; }
        public string Numero { get; set; }
        public string Intersecion { get; set; }
        public string IdProvincia { get; set; }
        public string IdCidudad { get; set; }

        //Derek 26/12/2013
        public bool check { get; set; }
        //Derek 03/01/2014
        public int Secuencia { get; set; }
        public string RutaArchivo { get; set; }
        public string Error { get; set; }



        public ro_empleado_gastos_perso_Info() { }

    }
}
