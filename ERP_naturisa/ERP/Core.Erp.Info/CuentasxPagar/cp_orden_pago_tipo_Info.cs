using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
///Prog: Héctor Ayauca
///V 10.13 22022014
///

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_orden_pago_tipo_Info
    {

        public string IdTipo_op { set; get; }
        public string Descripcion { set; get; }
        public string Estado { set; get; }
        public string GeneraDiario { set; get; }
        public bool check { get; set; }

        /// <summary>
        /// properties generados para la vista vwcp_orden_pago_tipo_x_empresa
        /// </summary>

        public int IdEmpresa { get; set; }
        public string IdCtaCble { get; set; }
        public string IdCtaCble_Credito { get; set; }
        public string IdCentroCosto { get; set; }
        public Nullable<int> IdTipoCbte_OP { get; set; }
        public Nullable<int> IdTipoCbte_OP_anulacion { get; set; }
        public string IdEstadoAprobacion { get; set; }

        public bool Dispara_Alerta { get; set; }






        public cp_orden_pago_tipo_Info() { }

    }
}
