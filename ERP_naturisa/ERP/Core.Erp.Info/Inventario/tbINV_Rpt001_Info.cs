using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class tbINV_Rpt001_Info
    {
        public int IdEmpresa_SP { get; set; }
        public string IdUsuario_SP { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string nom_pc { get; set; }
        public string Su_Descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public string IdCategoria { get; set; }
        public string ca_Categoria { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public Nullable<double> pr_peso { get; set; }
        public Nullable<double> stock { get; set; }
        public Nullable<double> Tonelaje_x_Sucursal { get; set; }
        public double pr_Pedidos { get; set; }
        public Nullable<double> Toneladas_x_Pedido { get; set; }
        public Nullable<double> Disponible { get; set; }
        public Nullable<double> Tonelaje_Disponible { get; set; }
        public tb_Empresa_Info InfoEmpresa { get; set; }

        public tbINV_Rpt001_Info()
        {

        }
    }
}
