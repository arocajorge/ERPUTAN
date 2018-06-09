using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
    public class fa_TipoNota_x_Empresa_x_Sucursal_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdTipoNota { get; set; }
        public string IdCtaCble { get; set; }
        public string Sucursal { get; set; }
        public Boolean Chek { get; set; }
        public string EstaEnBase { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public fa_TipoNota_x_Empresa_x_Sucursal_Info()
        {
            EstaEnBase = "N";
        }
    }
}
