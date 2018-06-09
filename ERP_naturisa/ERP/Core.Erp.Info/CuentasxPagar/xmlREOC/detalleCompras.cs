using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar.xmlREOC
{
    public class detalleCompras
    {

        public string tpIdProv { get; set; }
        public string idProv { get; set; }
        public string tipoComp { get; set; }
        public string aut { get; set; }
        public string estab { get; set; }
        public string ptoEmi { get; set; }
        public string sec { get; set; }
        public string fechaEmiCom { get; set; }
        public List<Core.Erp.Info.CuentasxPagar.xmlREOC.detalleAir> air { get; set; }

        public string autRet { get; set; }
        public string estabRet { get; set; }
        public string ptoEmiRet { get; set; }
        public string secRet { get; set; }
        public string fechaEmiRet { get; set; }

        public detalleCompras() { }
        

    }
}
