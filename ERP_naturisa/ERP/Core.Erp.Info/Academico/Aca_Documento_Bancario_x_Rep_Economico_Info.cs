using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
  public  class Aca_Documento_Bancario_x_Rep_Economico_Info
  {
      public int IdInstitucion { get; set; }
      public decimal IdFamiliar { get; set; }
      public string IdParentesco_cat { get; set; }
      public int IdDocumento_Bancario { get; set; }
      public int Id_tb_banco_x_mgbanco { get; set; }
      public int Id_tipo_meca_pago { get; set; }
      public Nullable<int> IdBanco { get; set; }
      public string Tipo_documento_cat { get; set; }
      public string Numero_Documento { get; set; }
      public Nullable<System.DateTime> Fecha_Expiracion { get; set; }
      public string Observacion { get; set; }
      public string IdUsuario { get; set; }
      public Nullable<System.DateTime> Fecha_Transac { get; set; }
      public string IdUsuarioUltMod { get; set; }
      public Nullable<System.DateTime> Fecha_UltMod { get; set; }
      public string IdUsuarioUltAnu { get; set; }
      public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
      public string Nom_pc { get; set; }
      public string Ip { get; set; }
      public string Motivo_anulacion { get; set; }
      public Nullable<bool> Estado { get; set; }
      public bool eliminar { get; set; }  
    }
}
