using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class prd_DespachoDetalle_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdDespacho { get; set; }
        public int Secuencia { get; set; }

        public decimal? IdOrdenTaller { get; set; }
        public TimeSpan Hora { get; set; }
        public decimal IdProducto { get; set; }
        public string CodigoBarraMaestro { get; set; }
        public string CodigoBarra { get; set; }
        public double  Cantidad { get; set; }
        public string Observacion { get; set; }
        public string ot_descripcion { get; set; }
        public string pr_descripcion { get; set; }
        public decimal precio { get; set; }
        public decimal peso { get; set; }

        public Boolean Checked { get; set; }
        public prd_DespachoDetalle_Info() { }

        //Adicionales para guia
        public string pr_descripcion_2 { get; set; }

    }
}
