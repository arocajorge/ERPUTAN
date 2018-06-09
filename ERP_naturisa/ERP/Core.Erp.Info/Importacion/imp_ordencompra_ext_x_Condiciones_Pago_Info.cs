using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Importacion
{
    public class imp_ordencompra_ext_x_Condiciones_Pago_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompraExt { get; set; }
        public int Secuencia { get; set; }
        public string IdCondicion_Pago { get; set; }
        public DateTime Fecha_Pago { get; set; }
        public string IdConfirmacion_Pago { get; set; }
        public double Por_Pago { get; set; }
        public double Valor_Pago { get; set; }
        public string Observacion { get; set; }


        public imp_ordencompra_ext_x_Condiciones_Pago_Info()
        {

        }
    }
}
