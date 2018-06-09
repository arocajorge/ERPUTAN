using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_guia_remision_valor_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdGuiaRemision { get; set; }
        public string IdTipoValor { get; set; }
        public int signo { get; set; }
        public double Valor { get; set; }
        
        public fa_guia_remision_valor_Info() { }
    }
}
