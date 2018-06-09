using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion
{
    public class fa_cliente_x_ct_centro_costo_Info
    {
        public int IdEmpresa_cli { get; set; }
        public decimal IdCliente_cli { get; set; }
        public int IdEmpresa_cc { get; set; }
        public string IdCentroCosto_cc { get; set; }
        public string Observacion { get; set; }

        //Campos de vista
        public string nom_Centro_costo { get; set; }
        public string nom_Cliente { get; set; }
    }
}
