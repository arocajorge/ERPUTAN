using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Bancos
{
  public  class ba_Archivo_Transferencia_x_PreAviso_Cheq_Info
    {

      public int IdEmpresa { get; set; }
      public decimal IdArchivo_preaviso_cheq { get; set; }
      public string cod_Archivo_preaviso_cheq { get; set; }
      public int IdBanco { get; set; }
      public string Nom_Archivo { get; set; }
      public string Observacion { get; set; }
      public DateTime Fecha { get; set; }
      public bool Estado { get; set; }
      public DateTime Fecha_Proceso { get; set; }
      public byte[] Archivo { get; set; }
      public string IdUsuario { get; set; }
      public DateTime ? Fecha_Transac { get; set; }
      public string IdUsuarioUltMod { get; set; }
      public DateTime ? Fecha_UltMod { get; set; }
      public string IdUsuarioUltAnu { get; set; }
      public DateTime ?Fecha_UltAnu { get; set; }
      public string Nom_pc { get; set; }
      public string Ip { get; set; }
      public string Motivo_anulacion { get; set; }


      public string nom_banco { get; set; }
      public string cb_giradoA { get; set; }


    }
}
