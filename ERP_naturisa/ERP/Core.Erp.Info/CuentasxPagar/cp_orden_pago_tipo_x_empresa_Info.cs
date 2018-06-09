using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
///Prog: Catherine Jimenez
///11:14 22/02/2014
///
namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_orden_pago_tipo_x_empresa_Info
    {
        public int IdEmpresa {get; set;}
        public string IdTipo_op {get; set;}
        public string IdCtaCble {get; set;}
        public string IdCentroCosto {get; set;}
        public Nullable<int> IdTipoCbte_OP {get; set;}
        public Nullable<int> IdTipoCbte_OP_anulacion { get; set; }
        public string IdEstadoAprobacion {get; set;}
        public string Buscar_FactxPagar { get; set; }

        public string nom_Tipo_op { get; set; }
        public string GeneraDiario { get; set; }
        public string Estado { get; set; }
        public Boolean Viene_de_Base { get; set; }
        public string IdCtaCble_Credito { get; set; }
        public bool Dispara_Alerta { get; set; }




        public cp_orden_pago_tipo_x_empresa_Info() { }
    }
}
