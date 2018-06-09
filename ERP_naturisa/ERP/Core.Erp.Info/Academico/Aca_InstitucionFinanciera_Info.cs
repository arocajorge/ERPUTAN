using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
  public  class Aca_InstitucionFinanciera_Info
    {
        public int IdInstitucionFinanciera { get; set; }
        public string CodigoInstitucion { get; set; }
        public string NombreInstitucion { get; set; }
        public string IdTipoCuentaCatalogo { get; set; }
        public string CodigoAlterno { get; set; }
        public string NombreAlterno { get; set; }
        public decimal Porc_comision { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaAnulacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }
        public Aca_Catalogo_Info catalogoInfo { get; set; }

        public Aca_InstitucionFinanciera_Info() {
            catalogoInfo = new Aca_Catalogo_Info();
        }
    }
}
