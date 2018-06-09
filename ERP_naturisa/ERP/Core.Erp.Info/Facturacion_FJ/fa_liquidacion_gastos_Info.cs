using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_liquidacion_gastos_Info
    {
        public int IdEmpresa { get; set; }
        public Decimal IdLiquidacion { get; set; }
        public int IdPeriodo { get; set; }
        public string cod_liquidacion { get; set; }
        public Decimal IdCliente { get; set; }
        public DateTime fecha_liqui { get; set; }
        public string Observacion { get; set; }
        public string estado { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transaccion { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }

        //datos adicionales para la vista
        public string pe_apellido { get; set; }
        public string pe_razonSocial { get; set; }
        public string pe_nombre { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_direccion { get; set; }
        public string pe_telefonoCasa { get; set; }


        public Nullable<double> Subtotal { get; set; }
        public Nullable<double> Iva { get; set; }
        public Nullable<double> total_liquidacion { get; set; }
        public string Periodo { get; set; }


        //lista de detalles
        public List<fa_liquidacion_gastos_det_Info> Lis_Detalle = new List<fa_liquidacion_gastos_det_Info>();
    }
}
