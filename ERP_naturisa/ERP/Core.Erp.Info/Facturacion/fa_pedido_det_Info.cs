using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_pedido_det_Info : fa_pedido_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdPedido { get; set; }
        public string CodProducto { get; set; }
        public double Peso { get; set; }
        public int Secuencial { get; set; }
        public decimal IdProducto { get; set; }
        public double dp_cantidad { get; set; }
        public double dp_precio { get; set; }
        public double dp_PorDescuento { get; set; }
        public double dp_desUni { get; set; }
        public double dp_PrecioFinal { get; set; }
        public double dp_subtotal { get; set; }
        public double dp_iva { get; set; }
        public double dp_total { get; set; }
        public string dp_pagaIva { get; set; }
        public bool Paga_Iva { get; set; }
        public string dp_detallexItems { get; set; }
        public string DesProduct { get; set; }
        public Boolean Checked { get; set; }
        public decimal dp_saldo { get; set; }

        // campos de la vista vwfa_pedido_detalle
        public string Tiene_Despacho { get; set; }
        public string Esta_en_Base { get; set; }


        public fa_pedido_det_Info() { }

    }
}
