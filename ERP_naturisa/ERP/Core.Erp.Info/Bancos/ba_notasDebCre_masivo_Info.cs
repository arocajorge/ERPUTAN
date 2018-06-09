using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Bancos
{
    public class ba_notasDebCre_masivo_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdTransaccion { get; set; }
        public int IdEmpresa_cb { get; set; }
        public decimal IdCbteCble_cb { get; set; }
        public int IdTipocbte_cb { get; set; }
        public string Observacion { get; set; }
        public string Deb_Cred { get; set; }
        public DateTime fecha { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public int TotalTransacciones { get; set; }

                     
        public ba_notasDebCre_masivo_Info(){ }
    }
}
