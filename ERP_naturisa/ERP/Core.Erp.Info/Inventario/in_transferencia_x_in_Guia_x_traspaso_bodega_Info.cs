using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
    public class in_transferencia_x_in_Guia_x_traspaso_bodega_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursalOrgen { get; set; }
        public int IdBodegaOrigen { get; set; }
        public decimal IdTransferencia { get; set; }
        public int IdEmpresa_Guia { get; set; }
        public decimal IdGuia { get; set; }
        public string Observacion { get; set; }

        public in_transferencia_x_in_Guia_x_traspaso_bodega_Info()
        {

        }
    }
}
