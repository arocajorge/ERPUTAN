using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.General
{
    public class tb_banco_estado_reg__resp_bancaria_Info
    {
        public int IdBanco { get; set; }
        public string IdEstado_Reg_cat { get; set; }
        public string IdEstado_Reg_Bancario { get; set; }
        public string observacion { get; set; }
        public Nullable<bool> Genera_anulacion { get; set; }
    }
}
