using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Compras
{
  public  class com_comprador_Info
    {

        public int IdEmpresa { get; set; }
        public decimal IdComprador { get; set; }
        public string IdUsuario_com { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public decimal ? IdPersona { get; set; }
        public string  cedula { get; set; }
        public string SEstado { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }

        public  com_comprador_Info(){}
    }
}
