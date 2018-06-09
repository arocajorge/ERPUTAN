using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Compras
{
    public class com_cotizacion_compra_det_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCotizacion { get; set; }
        public int Secuencia { get; set; }
       
        public double Cant_soli { get; set; }
        public double Cant_a_cotizar { get; set; }
        public string Observacion { get; set; }
        public int IdEmpresa_lq { get; set; }
        public decimal IdListadoMateriales_lq { get; set; }
        public int IdDetalle_lq { get; set; }
        public decimal IdProducto { get; set; }

        //campo vwcom_ListadoMateriales_Detalle
        public string Su_Descripcion { get; set; }
        public DateTime FechaReg { get; set; }
        public string pr_descripcion { get; set; }
        public Boolean Check { get; set; }

        public double Cant_soli_AUX { get; set; }
        public int IdSucursal { get; set; }
        public double Cant_a_cotizar_AUX { get; set; }
        public string IdCategoria { get; set; }
        public string ca_Categoria { get; set; }

        public double saldo { get; set; }
        public double saldo_AUX { get; set; }

      


    }
}
