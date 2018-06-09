using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
    public class vwcp_Conciliacion_Caja_Info
    {

        public int IdEmpresa { get; set; }
        public decimal IdConciliacion_Caja { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCaja { get; set; }
        public string IdEstadoCierre { get; set; }
        public string Observacion { get; set; }
        public int? IdEmpresa_op { get; set; }
        public decimal? IdOrdenPago_op { get; set; }
        public decimal Valor_Pagado { get; set; }
        public string nom_caja { get; set; }
        public string nom_Estado { get; set; }
        public string IdCtaCble { get; set; }


        public int Secuencia { get; set; }

        
        public double Saldo_cont_al_periodo { get; set; }
        public double Ingresos { get; set; }
        public double Total_Ing { get; set; }
        public double Total_fact_vale { get; set; }
        public double Total_fondo { get; set; }
        public double Dif_x_pagar_o_cobrar { get; set; }
        public int IdPeriodo { get; set; }

        public string IdUsuario { get; set; }


        public vwcp_Conciliacion_Caja_Info()
        {

        }

    }
}
