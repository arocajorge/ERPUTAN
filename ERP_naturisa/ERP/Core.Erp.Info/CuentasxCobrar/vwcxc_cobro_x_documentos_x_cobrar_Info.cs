using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
///Prog: Catherine Jimenez
///11:14 22/02/2014
///
namespace Core.Erp.Info.CuentasxCobrar
{
    public class vwcxc_cobro_x_documentos_x_cobrar_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdCobro { get; set; }
        public double cr_TotalCobro { get; set; }
        public DateTime cr_fecha { get; set; }
        public DateTime cr_fechaCobro { get; set; }
        public string cr_estado { get; set; }
        public string IdEstadoCobro { get; set; }
        public string cr_observacion { get; set; }
        public string NumDocumento { get; set; }
        public int secuencial { get; set; }
        public string TipoDoc_Aplicado { get; set; }
        public Nullable<int> IdBodega_Cbte_doc_aplica { get; set; }
        public decimal IdCble_vta_nota { get; set; }
        public string Documento_Aplicado { get; set; }
        public string Cliente { get; set; }
        public decimal IdCliente { get; set; }
        public string IdCobro_tipo { get; set; }
        public int saldo { get; set; }
        public string Sucursal { get; set; }
        public DateTime fechaini { get; set; }
        public DateTime fechaFin { get; set; }
        public string TipoFecha { get; set; }
        public string Bodega { get; set; }
        public string EstadoCobro { get; set;}
        public string TipoCobro { get; set; }
        public Nullable<double> SubTotal_Doc_vta { get; set; }
        public Nullable<double> Iva_Doc_vta { get; set; }
        public Nullable<double> Total_Doc_vta { get; set; }
        public DateTime Fecha_vta { get; set; }

        public vwcxc_cobro_x_documentos_x_cobrar_Info() { }

    }
}
