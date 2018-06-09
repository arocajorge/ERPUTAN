using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{
  public  class vwtb_persona_beneficiario_Info
    {
      
      public int IdEmpresa { get; set; }
      public string IdBeneficiario { get; set; }
      public string IdTipo_Persona { get; set; }
      public decimal IdPersona { get; set; }
      public decimal IdEntidad { get; set; }
      public string Codigo { get; set; }
      public string Nombre { get; set; }
      public string  pr_girar_cheque_a { get; set; }
      public string pe_razonSocial { get; set; }
      public string pe_cedulaRuc { get; set; }
      public string pe_Naturaleza { get; set; }
      public string IdCtaCble { get; set; }
      public string IdCentroCosto { get; set; }
      public string IdSubCentroCosto { get; set; }
      public decimal secuencial { get; set; }
      public string NombreCompleto { get; set; }
      public string IdCtaCble_Anticipo { get; set; }
      public string IdCtaCble_Gasto { get; set; }
      public string Estado { get; set; }
      public string ba_descripcion { get; set; }
      public string num_cta_acreditacion { get; set; }
      public string IdTipoCta_acreditacion_cat { get; set; }
      public string IdTipoDocumento { get; set; }
      public string CodigoLegal { get; set; }

      public vwtb_persona_beneficiario_Info() { }

    }
}
