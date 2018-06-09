using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico.Archivo_Para_Bancos
{
   public class VisaMastercardBankard_Bolivariano_Info
    {
       public string Tarjeta { get; set; }
       public string Comercio { get; set; }
        public string FechadeConsumo { get; set; }
        public string ValorConsumo	 { get; set; }
        public string ICE { get; set; }
        public string TipoConsumo { get; set; }
        public string NumerodeAutorizacion { get; set; }
        public string NumeroMesesDiferido { get; set; }
        public string NumeroPagare  { get; set; }
        public string Filler { get; set; }
        public string FechaExpiracion { get; set; }
        public string Iva { get; set; }
        public string TipodeDiferido { get; set; }
        public string Moneda { get; set; }
        public string Filer { get; set; }
        public string MontoGravaIva { get; set; }
        public string MontoNoGravaIVA  { get; set; }

    }
}
