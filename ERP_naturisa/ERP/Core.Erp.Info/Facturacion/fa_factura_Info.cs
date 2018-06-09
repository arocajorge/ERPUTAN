using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion_Grafinpren;
using Core.Erp.Info.Facturacion_FJ;

namespace Core.Erp.Info.Facturacion
{
    public class fa_factura_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public string CodCbteVta { get; set; }
        public string vt_tipoDoc { get; set; }
        public string vt_autorizacion { get; set; }
        public string vt_serie1 { get; set; }
        public string vt_serie2 { get; set; }
        public string vt_NumFactura { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public DateTime vt_fecha { get; set; }
        public decimal vt_plazo { get; set; }
        public DateTime vt_fech_venc { get; set; }
        public string vt_tipo_venta { get; set; }
        public string vt_Observacion { get; set; }
        public int IdPeriodo { get; set; }
        public int vt_anio { get; set; }
        public int vt_mes { get; set; }
        public double vt_seguro { get; set; }
        public double vt_flete { get; set; }
        public double vt_interes { get; set; }
        public double vt_OtroValor1 { get; set; }
        public double vt_OtroValor2 { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transaccion { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public string Bodega { get; set; }
        public string Sucursal { get; set; }
        public string Cliente { get; set; }
        public string Vendedor { get; set; }
        public double IVA { get; set; }
        public double Subtotal { get; set; }
        public double Subtotal0 { get; set; }
        public double SubtotalIVA { get; set; }
        public double Total { get; set; }
        public double Descuento { get; set; }
        public string DocImpTipo { get; set; }
        public decimal NumDocImp { get; set; }

        
        public int? IdCaja { get; set; }

        public List<fa_factura_det_info> DetFactura_List { get; set; }
        public List<fa_factura_x_fa_TerminoPago_Info>  DetformaPago_list { get; set; }
        public List<fa_factura_x_formaPago_Info> lista_formaPago_x_Factura { get; set; }
        public fa_factura_fj_Info Factura_Fj { get; set; }

        //personalizacion de grafinpren -----
        public fa_factura_graf_Info Factura_Graf { get; set; }
        //personalizacion de grafinpren -----
        public Academico.fa_factura_aca_Info Factura_CAH { get; set; }


        public int IdEmpresa_nc_anu { get; set; }
        public int IdSucursal_nc_anu { get; set; }
        public int IdBodega_nc_anu { get; set; }
        public decimal IdNota_nc_anu { get; set; }
        public string NomCliente { get; set; }
        public bool EsDocumentoElectronico { get; set; }

        public int ? IdPuntoVta { get; set; }
        public decimal IdEstudiante { get; set; }
        public string IdParentesco_cat { get; set; }
        public decimal IdFamiliar { get; set; }
        public string Estudiante { get; set; }
        public int IdRubro { get; set; }
        public fa_factura_Info()
        {
            lista_formaPago_x_Factura = new List<fa_factura_x_formaPago_Info>();
            DetFactura_List = new List<fa_factura_det_info>();
            DetformaPago_list = new List<fa_factura_x_fa_TerminoPago_Info>();
            Factura_Graf = new fa_factura_graf_Info();
            Factura_Fj = new fa_factura_fj_Info();
            Factura_CAH = new Academico.fa_factura_aca_Info();
        }
    }
}
