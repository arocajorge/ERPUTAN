using System.Collections.Generic;

namespace Core.Erp.Info.Compras
{
    public class com_OrdenPedidoPlantilla_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPlantilla { get; set; }
        public string op_Codigo { get; set; }
        public string op_Observacion { get; set; }
        public bool Estado { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public bool EsCompraUrgente { get; set; }
        public int? IdPunto_cargo { get; set; }

        public List<com_OrdenPedidoPlantillaDet_Info> ListaDetalle { get; set; }
    }
}
