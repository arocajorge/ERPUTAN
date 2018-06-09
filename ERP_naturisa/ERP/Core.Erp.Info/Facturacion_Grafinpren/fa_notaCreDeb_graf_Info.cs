using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_Grafinpren
{
    public class fa_notaCreDeb_graf_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdNota { get; set; }
        public string num_op { get; set; }
        public DateTime? fecha_op { get; set; }
        public string num_cotizacion { get; set; }
        public DateTime? fecha_cotizacion { get; set; }
        public int? IdEquipo { get; set; }
        public string nom_equipo { get; set; }
        public double? porc_comision { get; set; }

        //datos para campos adicionales
        public string sc_observacion { get; set; }
        public string pe_direccion { get; set; }
        public string pe_correo { get; set; }
    }
}
