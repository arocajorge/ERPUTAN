using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion
{
    public class fa_notaCreDeb_x_fa_factura_NotaDeb_Info
    {
        public int IdEmpresa_nt { get; set; }
        public int IdSucursal_nt { get; set; }
        public int IdBodega_nt { get; set; }
        public decimal IdNota_nt { get; set; }
        public int secuencia { get; set; }
        public int IdEmpresa_fac_nd_doc_mod { get; set; }
        public int IdSucursal_fac_nd_doc_mod { get; set; }
        public int IdBodega_fac_nd_doc_mod { get; set; }
        public decimal IdCbteVta_fac_nd_doc_mod { get; set; }
        public string vt_tipoDoc { get; set; }
        public double Valor_Aplicado { get; set; }
        public System.DateTime fecha_cruce { get; set; }
        public double Saldo { get; set; }

        //Validador al traer de base
        public bool esta_en_base { get; set; }

        //Campos vista
        public string vt_serie1 { get; set; }
        public string vt_serie2 { get; set; }
        public string vt_NumFactura { get; set; }
        public decimal IdCliente { get; set; }
        public string nom_Cliente { get; set; }
        public System.DateTime vt_fecha { get; set; }
        public Nullable<System.DateTime> vt_fech_venc { get; set; }
        public string vt_Observacion { get; set; }
        public Nullable<double> vt_total { get; set; }
        public Nullable<double> saldo { get; set; }
        public string num_doc { get; set; }

        //Campos cobro
        public Nullable<int> IdEmpresa_cbr { get; set; }
        public Nullable<int> IdSucursal_cbr { get; set; }
        public Nullable<decimal> IdCobro_cbr { get; set; }
    }
}
