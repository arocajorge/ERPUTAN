using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
    public class Aca_Tipo_mecanismo_de_pago_Info
    {
        public int Id_tb_banco_x_mgbanco { get; set; }
        public int Id_tipo_meca_pago { get; set; }
        public string nombre { get; set; }
        public Nullable<bool> estado { get; set; }
        public string tipo_cuenta { get; set; }
        public string forma_pago { get; set; }
        public string codigo { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string IdUsuario_Responsable { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotivoAnu { get; set; }
    }
}
