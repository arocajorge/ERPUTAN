using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Info.Facturacion
{
    public class fa_devol_venta_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdDevolucion { get; set; }
        public string CodDevolucion { get; set; }
        public decimal IdNota { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public decimal IdCbteVta { get; set; }
        public DateTime dv_fecha { get; set; }
        public string Estado { get; set; }
        public string dv_Observacion { get; set; }
        public string IdUsuario { get; set; }
        public double dv_seguro { get; set; }
        public double dv_flete { get; set; }
        public double dv_interes { get; set; }
        public double dv_OtroValor1 { get; set; }
        public double dv_OtroValor2 { get; set; }
        public string vt_serie1 { get; set; }
        public string vt_serie2 { get; set; }
        public string vt_NumFactura { get; set; }
        public string MotivoAnulacion { get; set; }
        
        public string Bodega { get; set; }
        public string Sucursal { get; set; }
        public string Cliente { get; set; }
        public string Vendedor { get; set; }
        public double IVA { get; set; }
        public double Subtotal { get; set; }
        public double Total { get; set; }

    
        public fa_notaCreDeb_Info InfoNotaCreDeb { get; set; }

        public in_movi_inve_Info InfoMovInve = new in_movi_inve_Info();


        public double totalDev { get; set; }

        public List<fa_devol_venta_det_Info> DetalleDeVta { get; set; }


        public int mvInv_IdEmpresa { get; set; }
        public int mvInv_IdSucursal { get; set; }
        public int mvInv_IdBodega { get; set; }
        public int mvInv_IdMovi_inven_tipo { get; set; }
        public decimal mvInv_IdNumMovi { get; set; }

        public int mvInv_IdEmpresa_x_Anu { get; set; }
        public int mvInv_IdSucursal_x_Anu { get; set; }
        public int mvInv_IdBodega_x_Anu { get; set; }
        public int mvInv_IdMovi_inven_tipo_x_Anu { get; set; }
        public decimal mvInv_IdNumMovi_x_Anu { get; set; }

        public fa_devol_venta_Info()
        {
            DetalleDeVta = new List<fa_devol_venta_det_Info>();
            InfoNotaCreDeb = new fa_notaCreDeb_Info();
            InfoMovInve = new in_movi_inve_Info();
        }
    }
}
