using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Bancos
{
   public class ba_transferencia_Info
    {
        public decimal IdTransferencia { get; set; }
        public int IdEmpresa_origen { get; set; }
        public decimal IdCbteCble_origen { get; set; }
        public int IdTipocbte_origen { get; set; }
        public int IdEmpresa_destino { get; set; }
        public decimal IdCbteCble_destino { get; set; }
        public int IdTipocbte_destino { get; set; }
        public string tr_observacion { get; set; }
        public double tr_valor { get; set; }
        public DateTime tr_fecha { get; set; }
        public string tr_estado { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuario_Anu { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public DateTime? Fecha_Transac { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public string ip { get; set; }
        public string nom_pc { get; set; }
        public string tr_MotivoAnulacion { get; set; }

        public int IdBanco_origen { get; set; }
        public int IdBanco_destino { get; set; }

        public string NEmpresaOrigen { get; set; }
        public string NEmpresaDestino { get; set; }
        public string NBancoOrigen { get; set; }
        public string NBancoDestino { get; set; }

       public ba_transferencia_Info(){}

     
    }
}
