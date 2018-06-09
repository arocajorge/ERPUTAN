using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Bancos
{
    public class vwba_notasDebCre_masivo_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdTransaccion { get; set; }
        public string tm_tipo { get; set; }
        public int tm_IdBanco { get; set; }
        public System.DateTime tm_fecha { get; set; }
        public string tm_observacion { get; set; }
        public double cb_Valor { get; set; }
        public string cb_Observacion { get; set; }
        public System.DateTime cb_Fecha { get; set; }
        public decimal cb_IdCbteCble { get; set; }
        public int cb_IdTipoCte { get; set; }
        public int IdTipoNota { get; set; }
        public string tn_descripcion { get; set; }
        public string tn_tipo { get; set; }
        public string tn_IdCtaCble { get; set; }
        public string tn_IdCentroCosto { get; set; }

        public vwba_notasDebCre_masivo_Info()
        {

        }
    }
}
