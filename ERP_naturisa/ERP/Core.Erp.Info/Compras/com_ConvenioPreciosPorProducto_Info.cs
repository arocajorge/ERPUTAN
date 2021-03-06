﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Compras
{
    public class com_ConvenioPreciosPorProducto_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdProducto { get; set; }
        public decimal IdProveedor { get; set; }
        public decimal IdComprador { get; set; }
        public string IdTerminoPago { get; set; }
        public string IdUnidadMedida { get; set; }
        public double PrecioUnitario { get; set; }
        public double PorDescuento { get; set; }
        public double Descuento { get; set; }
        public double PrecioFinal { get; set; }
        public int TiempoEntrega { get; set; }
        public System.DateTime FechaFin { get; set; }
        public bool SaltaPaso2 { get; set; }
        public bool SaltaPaso3 { get; set; }
        public bool SaltoPaso4 { get; set; }
        public bool SaltoPaso5 { get; set; }

        public string TerminoPago { get; set; }

        public string Producto { get; set; }

        public string pe_nombreCompleto { get; set; }
    }
}
