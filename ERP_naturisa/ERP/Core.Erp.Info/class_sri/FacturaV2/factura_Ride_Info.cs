using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Core.Erp.Info.class_sri.FacturaV2
{
   public class factura_Ride_Info
    {

        public string Num_Autorizacion { get; set; }
        public DateTime Fecha_Autorizacion { get; set; }
        public factura factura { get; set; }
        public Image Logo { get; set; }
        public string MAIL { get; set; }
        public string DIRECCION_CLIENTE { get; set; }


        public string REFERENCIA { get; set; }
        public string OBRA { get; set; }
        public string FORMA_PAGO { get; set; }
        public string FECHA_VENCI { get; set; }
        public string observaciones { get; set; }
        public decimal por_iva { get; set; }

        public List<pagosPago_info> List_FormaPago { get; set; }

        public factura_Ride_Info()
        {
            factura = new factura();
            List_FormaPago = new List<pagosPago_info>();
        }
    }
}
