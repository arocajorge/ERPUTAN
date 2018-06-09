using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt003_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdConciliacion { get; set; }
        public DateTime Fecha { get; set; }
        public string IdTipoConciliacion { get; set; }
        public double Saldo_por_aplicar { get; set; }
        public double Valor_Aplicado { get; set; }
        public string TipoDoc_vta { get; set; }
        public string Observacion { get; set; }
        public decimal IdCliente { get; set; }
        public string IdUsuario { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_telefonoCasa { get; set; }
        public string pe_direccion { get; set; }
        public string Su_Descripcion { get; set; }
        public int IdEmpresa_cbte_cble { get; set; }
        public int IdTipoCbte_cbte_cble { get; set; }
        public decimal IdCbteCble_cbte_cble { get; set; }
        public Image Logo { get; set; }
        public string numDocumento { get; set; }

        public XCXC_Rpt003_Info()
        {

        }
    }
}
