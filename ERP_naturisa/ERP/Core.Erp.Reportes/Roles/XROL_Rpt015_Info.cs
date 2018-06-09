using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Roles
{
    public class XROL_Rpt015_Info
    {
        public string em_nombre { get; set; }
        public string pe_nombreCompleto { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public string Observacion { get; set; }
        public int secuencia { get; set; }
        public string Detalle { get; set; }
        public int Vida_Util { get; set; }
        public double Cantidad { get; set; }
        public decimal IdAsignacion_Impl { get; set; }
        public string pr_descripcion { get; set; }
        public string pr_descripcion_2 { get; set; }
        public string pr_codigo { get; set; }
        public string Af_Nombre { get; set; }
        public string ca_descripcion { get; set; }
        public System.DateTime Fecha_Entrega { get; set; }
        public int IdNomina_Tipo { get; set; }
        public byte[] em_logo { get; set; }
        public string pe_cedulaRuc { get; set; }


    }
}
