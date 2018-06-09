using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
  public  class Aca_Tarjeta_cred_Info
    {
        public int IdTarjeta { get; set; }
        public string CodTarjeta { get; set; }
        public string nom_tarjeta { get; set; }
        public string estado { get; set; }
        public double porc_comision { get; set; }


        public DateTime  ? FechaAnulacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public string  MotivoAnulacion { get; set; }
        public string  UsuarioCreacion { get; set; }
        public string  UsuarioModificacion { get; set; }
        public DateTime ? FechaCreacion { get; set; }
        public DateTime ? FechaModificacion { get; set; }



    }
}
