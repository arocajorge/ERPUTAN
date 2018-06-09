using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_codigo_SRI_x_CtaCble_Info
    {
        public int IdEmpresa { get; set; }
        public string Empresa { get; set; }
        public int idCodigo_SRI { get; set; }
        public string IdCtaCble { get; set; }
        public DateTime fecha_UltMod { get; set; }
        public string idUsuario { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }


        public string pc_Cuenta { get; set; }
        public string pc_EsMovimiento{ get; set; }


        public cp_codigo_SRI_x_CtaCble_Info() { }
    }
}
