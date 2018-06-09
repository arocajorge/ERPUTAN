using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
   public class Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info
   {
       public int IdInstitucion { get; set; }
       public decimal IdFamiliar { get; set; }
       public string IdParentesco_cat { get; set; }
       public int IdDocumento_Bancario { get; set; }
       public decimal IdEstudiante { get; set; }
       public decimal IdMatricula { get; set; }
       public string Observacion { get; set; }
       public bool check { get; set; }


       public int Id_tipo_meca_pago { get; set; }
       public int Id_tb_banco_x_mgbanco { get; set; }
       public Nullable<int> IdBanco { get; set; }
       public string Tipo_documento_cat { get; set; }
       public string Numero_Documento { get; set; }
       public Nullable<System.DateTime> Fecha_Expiracion { get; set; }

    }
}
