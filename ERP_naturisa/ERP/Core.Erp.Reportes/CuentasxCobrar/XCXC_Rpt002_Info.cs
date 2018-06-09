using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt002_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdAnticipo { get; set; }
        public int Secuencia { get; set; }
        public string IdCobro_tipo { get; set; }
        public int IdEmpresa_Cobro { get; set; }
        public int IdSucursal_cobro { get; set; }
        public decimal IdCobro_cobro { get; set; }
        public DateTime cr_fechaCobro { get; set; }
        public string cr_observacion { get; set; }
        public string cr_Banco { get; set; }
        public string cr_cuenta { get; set; }
        public string cr_NumDocumento { get; set; }
        public string cr_Tarjeta { get; set; }
        public string cr_propietarioCta { get; set; }
        public double cr_TotalCobro { get; set; }
        public Image Logo { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_telefonoCasa { get; set; }
        public string pe_direccion { get; set; }

        public XCXC_Rpt002_Info()
        {

        }
    }
}
