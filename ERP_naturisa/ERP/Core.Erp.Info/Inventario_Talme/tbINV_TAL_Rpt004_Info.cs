using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario_Talme
{
    public class tbINV_TAL_Rpt004_Info
    {
        public string NomEmpresa { get; set; }
        public string IdUsuario_SP { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string nom_pc { get; set; }
        public Nullable<double> peso { get; set; }
        public string CodProducto { get; set; }
        public string Nom_Producto { get; set; }
        public string Nom_Categoria { get; set; }
        public string RutaPadreCategoria { get; set; }
        public Nullable<int> IdSucursal1 { get; set; }
        public string NomSucursal1 { get; set; }
        public Nullable<int> IdSucursal2 { get; set; }
        public string NomSucursal2 { get; set; }
        public Nullable<int> IdSucursal3 { get; set; }
        public string NomSucursal3 { get; set; }
        public Nullable<double> Uni_Inv_Fis_Sucu1 { get; set; }
        public Nullable<double> Uni_Inv_Fis_Sucu2 { get; set; }
        public Nullable<double> Uni_Inv_Fis_Sucu3 { get; set; }
        public Nullable<double> Uni_Inv_Fis_total { get; set; }
        public Nullable<double> Ton_Inv_Fis_total { get; set; }
        public Nullable<double> Uni_Inv_Sys_Sucu1 { get; set; }
        public Nullable<double> Uni_Inv_Sys_Sucu2 { get; set; }
        public Nullable<double> Uni_Inv_Sys_Sucu3 { get; set; }
        public Nullable<double> Uni_Inv_Sys_total { get; set; }
        public Nullable<double> Ton_Inv_Sys_total { get; set; }
        public Nullable<double> Dif_Uni { get; set; }
        public decimal  ID { get; set; }

        public tbINV_TAL_Rpt004_Info()
        {

        }

    }
}
