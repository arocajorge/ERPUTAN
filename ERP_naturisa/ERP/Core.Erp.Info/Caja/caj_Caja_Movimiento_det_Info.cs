using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;

namespace Core.Erp.Info.Caja
{//22042013
    public class caj_Caja_Movimiento_det_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdTipocbte { get; set; }
        public int Secuencia { get; set; }
        public string IdCobro_tipo { get; set; }
        public DateTime cr_fecha { get; set; }
        public double cr_Valor { get; set; }
        public string cr_Banco { get; set; }
        public string cr_cuenta { get; set; }
        public string cr_NumDocumento { get; set; }
        public DateTime? cr_fechaDocu { get; set; }
        public decimal? IdOrdenPago { get; set; }
        public int? IdEmpresa_OP { get; set; }

        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public Nullable<decimal> IdTipoFlujo { get; set; }
        public cxc_cobro_Det_Info info_det_cobro { get; set; }


        public caj_Caja_Movimiento_det_Info()
        {
            cr_fecha = DateTime.Now.Date;
            cr_fechaDocu = DateTime.Now.Date;
            info_det_cobro = new cxc_cobro_Det_Info();
        }
    }
}
