using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt017_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbte_vta_nota { get; set; }
        public string dc_TipoDocumento { get; set; }
        public double vt_total { get; set; }
        public double dc_ValorPago { get; set; }
        public double Saldo { get; set; }
        public decimal IdCliente { get; set; }
        public decimal IdPersona { get; set; }
        public string nom_Cliente { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string IdProvincia { get; set; }
        public string IdCiudad { get; set; }
        public string IdParroquia { get; set; }
        public string pe_Naturaleza { get; set; }
        public string vt_NumFactura { get; set; }
        public System.DateTime vt_fecha { get; set; }
        public System.DateTime vt_fech_venc { get; set; }
        public double ValorPago_mes { get; set; }
    }
}
