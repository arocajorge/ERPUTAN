﻿using System;

namespace Core.Erp.Info.MobileSCI
{
    public class tbl_movimientos_det_Info
    {
        public decimal IdSincronizacion { get; set; }
        public int IdSecuencia { get; set; }
        public string IdUsuarioSCI { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdProducto { get; set; }
        public string IdUnidadMedida { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public System.DateTime Fecha { get; set; }
        public double cantidad { get; set; }
        public Nullable<int> IdEmpresa_oc { get; set; }
        public Nullable<int> IdSucursal_oc { get; set; }
        public Nullable<decimal> IdOrdenCompra { get; set; }
        public Nullable<int> secuencia_oc { get; set; }
        public string pr_descripcion { get; set; }
        public string nom_unidad_medida { get; set; }
        public bool Aprobado { get; set; }
        public string Estado { get; set; }
        public string Su_Descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public string nom_centro { get; set; }
        public string nom_subcentro { get; set; }
        public System.DateTime Fecha_sincronizacion { get; set; }
        public double do_precioFinal { get; set; }

        public bool Checked_A { get; set; }
        public bool Checked_R { get; set; }

        //Campos csv
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public int Secuencia { get; set; }
        public string CodProduccionSC { get; set; }
        public string CodProduccionPro { get; set; }
    }
}