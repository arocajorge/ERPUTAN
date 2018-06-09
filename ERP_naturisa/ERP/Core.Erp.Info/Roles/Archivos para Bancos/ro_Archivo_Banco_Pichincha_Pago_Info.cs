using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles.Archivos_para_Bancos
{
  public  class ro_Archivo_Banco_Pichincha_Pago_Info
  {
      public string codigoOrientacion { get; set; }
      public string contraPartida { get; set; }
      public string moneda { get; set; }
      public string valor { get; set; }
      public string formaCobroPago { get; set; }
      public string tipoCuenta { get; set; }
      public string numeroCuenta { get; set; }
      public string referencia { get; set; }
      public string tipoIdCliente { get; set; }
      public string numeroIdCliente { get; set; }
      public string nombreCliente { get; set; }
      public string cobroBaseImponible { get; set; }
      public string pagoCodigoBanco { get; set; }
    }
}
