using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Bancos
{
   public class ba_Transacciones_x_excel_a_conciliar_Info
    {


        public int SecuenciaFila { get; set; }
        public DateTime Fecha{ get; set; }
        public eTipo_Movimiento Tipo_Movimiento { get; set; }
        public string sTipo_Movimiento { get; set; }

        public string Documento { get; set; }
        public string Concepto { get; set; }
        public string Agencia { get; set; }
        public decimal Valor { get; set; }
        public string Referencia { get; set; }
        public string Signo { get; set; }
        public int IdEmpresa { get; set; }
        public string MensajeValidacion { get; set; }

        public enum eTipo_Movimiento
        {
            CHQ,
            ND,
            NC,
            DEP
        }

        
    }
}
