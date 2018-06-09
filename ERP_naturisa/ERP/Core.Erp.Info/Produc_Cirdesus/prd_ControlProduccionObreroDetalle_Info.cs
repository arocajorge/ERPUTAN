using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class prd_ControlProduccionObreroDetalle_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdControlProduccionObrero { get; set; }
        public int Secuencia { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraControl { get; set; }
        public double Cantidad { get; set; }
        public DateTime IdFecha { get; set; }
        public string Cerrado { get; set; }
        public string CodBarra { get; set; }
        public string CodBarraMaestro { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_descripcion { get; set; }

        public Boolean Checked { get; set; }
        public prd_ControlProduccionObreroDetalle_Info() { }
    }
}
