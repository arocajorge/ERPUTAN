using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;

namespace Core.Erp.Info.Compras
{
    public class com_rpt_ordencompra_local_Info
    {
        public com_ordencompra_local_Info OrdenCompraCab { get; set; }
        public List<com_ordencompra_local_det_Info> OrdenCompraDet { get; set; }
        public double ocTotal { get; set; }
        public double octtiva { get; set; }
        public double ocsubtotal { get; set; }
        public double ocdescuento { get; set; }
      

        public com_rpt_ordencompra_local_Info()
        {
            OrdenCompraCab = new com_ordencompra_local_Info();
            OrdenCompraDet = new List<com_ordencompra_local_det_Info> ();
        }

    }
}
