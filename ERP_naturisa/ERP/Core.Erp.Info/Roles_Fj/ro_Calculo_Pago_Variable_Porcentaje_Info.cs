using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles_Fj
{
    public class ro_Calculo_Pago_Variable_Porcentaje_Info
    {
        public int IdEmpresa { get; set; }
        public int IdTipo_Nomina { get; set; }
        public int IdEfectividad { get; set; }
        public double Efec_Entrega_Rango { get; set; }
        public double Efec_Entrega_Aplica { get; set; }
        public double Efec_Volumen_Rango { get; set; }
        public double Efec_Volumen_Aplica { get; set; }
        public double Recup_Cartera_Rango { get; set; }
        public double Recup_Cartera_Aplica { get; set; }
        public bool Estado { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transaccion { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
    }
}
