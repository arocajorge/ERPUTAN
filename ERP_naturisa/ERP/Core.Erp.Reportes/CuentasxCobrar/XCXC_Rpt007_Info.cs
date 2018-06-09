using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt007_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public string vt_tipoDoc { get; set; }
        public string numDocumento { get; set; }
        public decimal IdCliente { get; set; }
        public DateTime vt_fecha { get; set; }
        public decimal vt_plazo { get; set; }
        public DateTime vt_fech_venc { get; set; }
        public string Su_Descripcion { get; set; }
        public double vt_total { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string Tipo { get; set; }
        public Image Logo { get; set; }
        public string IdCobro_tipo { get; set; }
        public int DiasVencidos { get; set; }
        public string IdEstadoCobro { get; set; }
        public double Monto { get; set; }
        public double TotalCobrado { get; set; }
        public double Valor_Vencido { get; set; }
        public double Valor_x_Vencer { get; set; }
        public string Documento_Grupo { get; set; }

        

        public XCXC_Rpt007_Info()
        {

        }
    }
}
