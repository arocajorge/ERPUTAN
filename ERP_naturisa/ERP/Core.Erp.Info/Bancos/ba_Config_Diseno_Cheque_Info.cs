using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Bancos
{
   public class ba_Config_Diseno_Cheque_Info
    {
        public int idEmpresa { get; set; }
        public int idBanco { get; set; }
        public int Area_Imprimir_X { get; set; }
        public int Area_Imprimir_Y { get; set; }
        public int Tama_Cheque_X{ get; set; }
        public int Tama_Cheque_Y { get; set; }
        public int PagueseA_X { get; set; }
        public int PagueseA_Y{ get; set; }
        public int ValorCheque_X { get; set; }
        public int ValorCheque_Y { get; set; }
        public int ValorLetra_Cheque_X { get; set; }
        public int ValorLetra_Cheque_Y { get; set; }
        public int Fecha_X { get; set; }
        public int Fecha_Y { get; set; }
        public string Nom_Impresora { get; set; }
        public string  Pto_Impresora { get; set; }

   }
}
