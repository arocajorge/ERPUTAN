using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Compras
{
    public class com_OrdenPedidoDet_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdOrdenPedido { get; set; }
        public int Secuencia { get; set; }
        public decimal? IdProducto { get; set; }
        public string pr_descripcion { get; set; }
        public string IdUnidadMedida { get; set; }
        public int IdSucursalOrigen { get; set; }
        public int IdSucursalDestino { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public double opd_Cantidad { get; set; }
        public double opd_CantidadApro { get; set; }
        public string opd_EstadoProceso { get; set; }
        public string opd_Detalle { get; set; }
        public double? Stock { get; set; }
        public bool NuevoAdjunto { get; set; }
        #region Campos que no existen en la tabla
        public string IdUnidadMedida_Consumo { get; set; }
        public bool A { get; set; }
        public bool R { get; set; }
        #endregion


        public string nom_solicitante { get; set; }

        public bool Adjunto { get; set; }

        public string EstadoDetalle { get; set; }

        public string op_Observacion { get; set; }

        public DateTime op_Fecha { get; set; }

        public string NombreArchivo { get; set; }

        public string NomComprador { get; set; }
    }
}
