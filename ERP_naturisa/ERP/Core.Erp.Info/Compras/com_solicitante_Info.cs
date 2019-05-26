using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Compras
{
   public class com_solicitante_Info
    {

       public int IdEmpresa { get; set; }
       public decimal IdSolicitante { get; set; }
       public string nom_solicitante { get; set; }
       public string estado { get; set; }
       public string IdUsuario { get; set; }
       public string nom_departamento { get; set; }
       public decimal? IdDepartamento { get; set; }

       public string IdUsuarioUltMod { get; set; }
       public string MotiAnula { get; set; }
       public string SEstado { get; set; }

       public List<com_solicitante_aprobador_Info> ListaDetalle { get; set; }
    }
}
