using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles.AGP
{
    public class gastosPersonales
    {

        public string tipoIdentificacion { get; set; }
        public string identificacion { get; set; }
        public string nombresApellidos { get; set; }
        public string dirCalle { get; set; }
        public string dirNumero { get; set; }
        public string dirInterseccion { get; set; }
        public string dirProvincia { get; set; }
        public string dirCanton { get; set; }
        public string telefono { get; set; }
        public string periodoFiscal { get; set; }

        public List<detalleConyugueDependiente> conyugueDependiente { get; set; }
        public List<detallesHijosDependientes> hijosDependientes { get; set; }   
        public List<detalleDiscapacitadosDependientes>  discapacitadosDependientes { get; set; }
        public List<detalleGasto>  gastos { get; set; }
        public List<detalleRubrosNoIdentificanProveedor>  rubrosNoIdentificanProveedor { get; set; }


        public gastosPersonales()
        {

        }

    }
}
