using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_cotizacion_valor_info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdCotizaion { get; set; }
        public string IdTipoValor { get; set; }
        public int Signo { get; set; }
        public double Valor { get; set; }
        public fa_cotizacion_valor_info(){ }
    }

   
}
