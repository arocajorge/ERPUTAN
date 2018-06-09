using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_devol_venta_det_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdDevolucion { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double dv_cantidad { get; set; }
        public double dv_valor { get; set; }
        public double dv_PorDescUni { get; set; }
        public double dv_descUni { get; set; }
        public double dv_PrecioFinal { get; set; }
        public double dv_subtotal { get; set; }
        public double dv_iva { get; set; }
        public double dv_total { get; set; }
        public double dv_costo { get; set; }
     
        public string  sc_pagaIva { get; set; }
        public bool Paga_Iva { get; set; }

    
        public fa_devol_venta_det_Info()
        {

        }
    }
}
