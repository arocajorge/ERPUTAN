using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.Factuarcion_CAH;

namespace Core.Erp.Info.Facturacion
{
    public class fa_notaCreDeb_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdNota { get; set; }
        public string CreDeb { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public DateTime? no_fecha { get; set; }
        public string no_dev_venta { get; set; }
        public int IdTipoNota { get; set; }
        public string sc_observacion { get; set; }
        public string sc_usuario { get; set; }
        public decimal? IdDevolucion { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public string MotiAnula { get; set; }
        public string CodNota { get; set; }
        public DateTime? no_fecha_venc { get; set; }
        public DateTime? fecha_Ctble { get; set; }
        public string NaturalezaNota { get; set; }
        public string Serie1 { get; set; }
        public string Serie2 { get; set; }
        public string NumNota_Impresa { get; set; }
        public string NumAutorizacion { get; set; }
        public string CodDocumentoTipo { get; set; }
        public string IdTipoDoc { get; set; }
       

        public int IdCaja { get; set; }
        public string CodDevolucion { get; set; }


        public List<fa_notaCreDeb_det_Info> ListaDetalles { get; set; }

        
        public string IdCtaCble_TipoNota { get; set; }

        public string Cliente { get; set; }
        public string Sucursal { get; set; }
        public string Bodega { get; set; }
        public string Vendedor { get; set; }
        public double Subtotal { get; set; }
        public double Subtotal0 { get; set; }
        public double SubtotalIVA { get; set; }
        public double Descuento { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }
  


        public double flete	{ get; set; }
        public double interes	{ get; set; }
        public double valor1	{ get; set; }
        public double valor2	{ get; set; }


        public double seguro { get; set; }

        public DateTime dv_fecha { get; set; }
        public string IdUsuario { get; set; }

        public cxc_cobro_Info CobroInfo { get; set; }
        public Facturacion_Grafinpren.fa_notaCreDeb_graf_Info NotaCreDeb_Graf_Info { get; set; }
        public Nullable<int> IdEmpresa_fac_doc_mod { get; set; }
        public Nullable<int> IdSucursal_fac_doc_mod { get; set; }
        public Nullable<int> IdBodega_fac_doc_mod { get; set; }
        public Nullable<decimal> IdCbteVta_fac_doc_mod { get; set; }


        public int IdPuntoVta { get; set; }


        public List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info> lst_docs_relacionados { get; set; }
        public tb_sis_Documento_Tipo_Talonario_Info Info_sisDocTipoTalo { get; set; }
        public fa_Cliente_Info info_cliente { get; set; }
        public ct_Cbtecble_Info info_CbteCble { get; set; }

        public fa_notaCredDeb_aca_Info Info_notaCredDeb_aca { get; set; }


        

        public fa_notaCreDeb_Info() {

            ListaDetalles = new List<fa_notaCreDeb_det_Info>();
            CobroInfo = new cxc_cobro_Info();
            NotaCreDeb_Graf_Info = new Facturacion_Grafinpren.fa_notaCreDeb_graf_Info();
            lst_docs_relacionados = new List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info>();
            Info_sisDocTipoTalo = new tb_sis_Documento_Tipo_Talonario_Info();
            info_cliente = new fa_Cliente_Info();
            Info_notaCredDeb_aca = new fa_notaCredDeb_aca_Info();
        }
    }
}
