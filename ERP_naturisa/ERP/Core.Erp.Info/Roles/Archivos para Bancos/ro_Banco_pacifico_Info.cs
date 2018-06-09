using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles
{
  public  class ro_Banco_pacifico_Info
    {
      public string Localidad { get; set; }
      public string Transacción { get; set; }
        public string Codigo_de_Servicio { get; set; }
        public string Tipo_de_Cuenta { get; set; }
        public string Numero_de_cuenta { get; set; }
        public string Valor { get; set; }
        public string Identificacion_del_Servicio { get; set; }
        public string Referencia_para_el_estado_de_cuenta { get; set; }
        public string Forma_de_pago { get; set; }
        public string Moneda_del_movimiento { get; set; }
        public string Nombre_del_Beneficiario { get; set; }
        public string Localidad_de_retiro_del_cheque { get; set; }
        public string Agencia_de_retiro_del_cheque { get; set; }
        public string Tipo_NUC_del_Beneficiario { get; set; }
        public string Numero_unico_del_Beneficiario { get; set; }

    }
}
