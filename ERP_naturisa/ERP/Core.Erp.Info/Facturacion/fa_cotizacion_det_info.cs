using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_cotizacion_det_info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCotizacion { get; set; }
        public int Secuencial { get; set; }
        //public string CodProducto { get; set; }
        public decimal IdProducto { get; set; }
        public double dc_cantidad { get; set; }
        public double dc_precio { get; set; }
        public double dc_por_desUni { get; set; }
        public double dc_desUni { get; set; }
        public double dc_precioFinal { get; set; }
        public double dc_subtotal { get; set; }
        public double dc_iva { get; set; }
        public double dc_total { get; set; }
        public string dc_pagaIva { get; set; }
        public string dc_detallexItems { get; set; }
        public double dc_peso { get; set; }
        public bool Paga_Iva { get; set; }
        



         public  fa_cotizacion_det_info(){ }

    }
   
}
