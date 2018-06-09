using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.General
{
    public class vwtb_Ubicacion_Geografica_Info
    {
        public string ID { get; set; }
        public string IdPadre { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        public string Estado { get; set; }
        public int Nivel { get; set; }
        public string IdProvincia { get; set; }
        public string IdCiudad { get; set; }
        public string IdPais { get; set; }

        public vwtb_Ubicacion_Geografica_Info()
        {

        }
    }
}
