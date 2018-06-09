using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
   public  class Aca_InstitucionFinanciera_x_cod_establecimiento_Info
    {

        public Aca_InstitucionFinanciera_Info InstitucionFinaciera_Info { get; set; }
        public int IdInstitucionFinanciera { get; set; }
        public string IdCodigoFee_catalogo { get; set; }
        public string NumeroEstablecimiento { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaAnulacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }

        public Aca_InstitucionFinanciera_x_cod_establecimiento_Info()
        {
            InstitucionFinaciera_Info = new Aca_InstitucionFinanciera_Info();
        }

    }
}
