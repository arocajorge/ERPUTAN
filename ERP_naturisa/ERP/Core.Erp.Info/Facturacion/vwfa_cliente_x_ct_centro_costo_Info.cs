using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion
{
    public class vwfa_cliente_x_ct_centro_costo_Info
    {
        public string pe_razonSocial { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_direccion { get; set; }
        public string pe_telefonoOfic { get; set; }
        public string pe_telefonoCasa { get; set; }
        public string pe_correo { get; set; }
        public string pe_Naturaleza { get; set; }
        public string pe_estado { get; set; }
        public string IdTipoDocumento { get; set; }
        public decimal IdCliente_cli { get; set; }
        public string IdCentroCosto_cc { get; set; }
        public int IdEmpresa_cc { get; set; }
        public int IdEmpresa_cli { get; set; }
        public string IdActividadComercial { get; set; }
        public string Estado { get; set; }
        public string IdProvincia { get; set; }
        public string IdPais { get; set; }
        public string Descripcion_Ciudad { get; set; }
        public string nom_Centro_costo { get; set; }
        public string nom_Cliente { get; set; }
    }
}
