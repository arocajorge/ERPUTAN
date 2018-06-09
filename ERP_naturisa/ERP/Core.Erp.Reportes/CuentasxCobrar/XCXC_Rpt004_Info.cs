using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt004_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdCobro { get; set; }
        public string IdCobro_tipo { get; set; }
        public string cr_Banco { get; set; }
        public string cr_cuenta { get; set; }
        public string cr_NumDocumento { get; set; }
        public string cr_Tarjeta { get; set; }
        public string cr_propietarioCta { get; set; }
        public double cr_TotalCobro { get; set; }
        public DateTime cr_fechaCobro { get; set; }
        public string cr_observacion { get; set; }
        public decimal IdCliente { get; set; }
        public string IdUsuario { get; set; }
        public string  dc_TipoDocumento { get; set; }
        public int ? IdBodega_Cbte { get; set; }
        public decimal ? IdCbte_vta_nota { get; set; }
        public double dc_ValorPago { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_telefonoCasa { get; set; }
        public string pe_direccion { get; set; }
        public string Su_Descripcion { get; set; }
        public int IdBanco { get; set; }
        public int IdCaja { get; set; }
        public string Documento_Cobrado { get; set; }
        public Image Logo { get; set; }

        public XCXC_Rpt004_Info()
        {

        }
    }
}
