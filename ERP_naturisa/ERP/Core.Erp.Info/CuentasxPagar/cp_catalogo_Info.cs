using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//DEREK MEJIA 17/03/2014
namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_catalogo_Info
    {
        public string IdCatalogo { get; set; }
        public string IdCatalogo_tipo { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public string Abrebiatura { get; set; }
        public string NombreIngles { get; set; }
        public int Orden { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime FechaUltMod { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }


        public cp_catalogo_Info() { }
    }
}
