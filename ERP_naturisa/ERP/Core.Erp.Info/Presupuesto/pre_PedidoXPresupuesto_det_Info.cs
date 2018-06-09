using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Presupuesto
{
    public class pre_PedidoXPresupuesto_det_Info 
    {
        public int IdEmpresa { get; set; }
        public decimal IdPedidoXPre { get; set; }
        public int Secuencia_reg { get; set; }
        public decimal IdPresupuesto_pre { get; set; }
        public int IdAnio_pre { get; set; }
        public int Secuencia_pre { get; set; }
        public string Producto { get; set; }
        public double Cant { get; set; }

        public string NPresupuesto_pre { get; set; }

        public string CodEstadoAprobacion { get; set; }
        public string Cotizado { get; set; }
        public bool CotizadoB { get; set; }
        public DateTime? UltiFechaEstadoApro { get; set; }
        public string  IdUsuarioEstadoApro { get; set; }
        //para Aprobacion 
        public int? IdDepartamento { get; set; }
        public DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public decimal? IdProveedor1 { get; set; }
        public decimal? IdProveedor2 { get; set; }
        public decimal? IdProveedor3 { get; set; }
        public string IdUsuario { get; set; }
        public string do_NumDocumento { get; set; }

        public pre_PedidoXPresupuesto_det_Info(){}

    }
}
