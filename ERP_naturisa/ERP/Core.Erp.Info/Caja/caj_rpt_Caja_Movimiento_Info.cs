using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Caja;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;


namespace Core.Erp.Info.Caja
{
    public class caj_rpt_Caja_Movimiento_Info
    {
        public caj_Caja_Movimiento_Info MovimientoCaja { get; set; }
        public tb_Empresa_Info Empresa { get; set; }
        public List<ct_Cbtecble_det_Info> diario { get; set; }

        public caj_rpt_Caja_Movimiento_Info(){}
    }
}
