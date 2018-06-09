using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar.xmlATS
{
    public class detalleCompras
    { 
        public string codSustento { get; set; }
        public string tpIdProv { get; set; }
        public string idProv { get; set; }
        public string tipoComprobante { get; set; }

        public string tipoProv { get; set; }
        public string parteRel { get; set; }// esta NO quemado verificar

        public string fechaRegistro { get; set; }
        public string establecimiento  { get; set; }
        public string puntoEmision  { get; set; }
        public string secuencial { get; set; }
        public string fechaEmision { get; set; }
        public string autorizacion { get; set; }
        public string baseNoGraIva { get; set; }
        public string baseImponible { get; set; }
        public string baseImpGrav { get; set; }
        public string montoIce { get; set; }
        public string montoIva { get; set; }
        public string valorRetBienes { get; set; }
        public string valorRetServicios { get; set; }
        public string valRetServ100 { get; set; }

        public pagoExterior pagoExterior { get; set; }//
      //  public ArrformasDePago formasDePago { get; set; }//
        [System.Xml.Serialization.XmlArrayItemAttribute("formaPago", IsNullable = false)]
        public string[] formasDePago { get; set; }//
        
        public List<reembolso> reembolsos { get; set; }//

        public List<detalleAir> air { get; set; }
        public string estabRetencion1 { get; set; }
        public string ptoEmiRetencion1 { get; set; }
        public string secRetencion1 { get; set; }
        public string autRetencion1  { get; set; }
        public string fechaEmiRet1 { get; set; }

        public string docModificado { get; set; }
        public string estabModificado { get; set; }
        public string ptoEmiModificado { get; set; }
        public string secModificado { get; set; }
        public string autModificado { get; set; }


       

        public detalleCompras(){ }



    }
}
